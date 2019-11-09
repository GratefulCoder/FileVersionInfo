using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFileVersionInfo
{
	public class Utility
	{
		public static string GetFileVersionInformation(List<string> directory, List<string> targetFileExtensions, CheckedListBox.CheckedItemCollection desiredFileAttributes)
		{
			StringBuilder sb = new StringBuilder();

			//List DateTime for header:
			sb.Append("DateTime of this version capture: " + DateTime.Now.ToString() + Environment.NewLine);

			//loop through the directory entered by the user and find all files that meet the condition set by the user input value
			//for target file extensions in the UI. If file is found that meets the conditions, obtain that files version information and
			//append it to a StringBuilder object that will later be exported to a results file.
			foreach (string fileOrFolder in directory)
			{
				List<string> targetFiles = new List<string>(GetTargetFiles(targetFileExtensions, fileOrFolder));

				if (targetFiles.Count == 0)
				{
					sb.Append(String.Format(Environment.NewLine + "ERROR - the target you entered does not exist, has no matching files, or is unavailable: {0}" + Environment.NewLine, fileOrFolder));
					continue;
				}

				SetColumnHeaders(sb, fileOrFolder, desiredFileAttributes);

				foreach (string file in targetFiles)
				{
					AppendFileInfo(sb, file, desiredFileAttributes);
				}
			}
			return sb.ToString();
		}

		private static void AppendFileInfo(StringBuilder sb, string file, CheckedListBox.CheckedItemCollection desiredFileAttributes)
		{
			foreach (string attribute in desiredFileAttributes)
			{
				switch (attribute)
				{
					case "Filename":
						sb.Append(String.Format($@"{Path.GetFileName(file),-85}"));
						break;
					case "Version Number (Major.Minor.Build.Private)":
						FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(file);
						sb.Append(String.Format($@"{myFileVersionInfo.FileMajorPart + "."
												 + myFileVersionInfo.FileMinorPart + "."
												 + myFileVersionInfo.FileBuildPart + "."
												 + myFileVersionInfo.FilePrivatePart,-40}"));
						break;
					case "LastModified":
						sb.Append(String.Format($@"{File.GetLastWriteTime(file),-45}"));
						break;
					case "Full Path":
						sb.Append(String.Format($@"{file,-500}"));
						break;
					default:
						break;
				}
			}
			sb.Append(Environment.NewLine);

			//sb.Append(String.Format(
			//	 $@"{filename,-85}"
			//	 + $@"{myFileVersionInfo.FileMajorPart + "."
			//	 + myFileVersionInfo.FileMinorPart + "."
			//	 + myFileVersionInfo.FileBuildPart + "."
			//	 + myFileVersionInfo.FilePrivatePart,-40}"
			//	 + $@"{lastModified,-45}"
			//	 + $@"{file,-500}"
			//	 + Environment.NewLine));
		}

		private static void SetColumnHeaders(StringBuilder sb, string fileOrFolder, CheckedListBox.CheckedItemCollection desiredFileAttributes)
		{
			string hostName = GetHostNameOfTarget(fileOrFolder);

			sb.Append(Environment.NewLine + Environment.NewLine + hostName + Environment.NewLine);

			foreach (string attribute in desiredFileAttributes)
			{
				switch (attribute)
				{
					case "Filename":
						sb.Append(String.Format($@"{attribute + ":",-85}"));
						break;
					case "Version Number (Major.Minor.Build.Private)":
						sb.Append(String.Format($@"{"Version Number:",-40}"));
						break;
					case "LastModified":
						sb.Append(String.Format($@"{attribute + ":",-45}"));
						break;
					case "Full Path":
						sb.Append(String.Format($@"{attribute + ":",-500}"));
						break;
					default:
						break;
				}
			}
			sb.Append(Environment.NewLine);

			//sb.Append(String.Format(
			//			  $@"{"File:",-85}"
			//			+ $@"{"Version number: ",-40}"
			//			+ $@"{"LastModified:",-45}"
			//			+ $@"{"Full Path:",-500}") + Environment.NewLine);
		}

		private static string GetHostNameOfTarget(string fileOrFolder)
		{
			//construct Uri and append HOST name portion into StringBuilder object to seperate categories and headers
			string hostName = "Unknown Host";
			hostName = Path.GetPathRoot(fileOrFolder);

			if (Path.IsPathRooted(fileOrFolder))
			{
				if (Uri.TryCreate(fileOrFolder, UriKind.RelativeOrAbsolute, out Uri uri))
				{
					hostName = (String.IsNullOrWhiteSpace(uri.Host) ? Environment.MachineName : uri.Host);
				}
			}

			return hostName;
		}

		private static List<string> GetTargetFiles(List<string> targetFileExtensions, string targetDirectory)
		{
			List<string> targetFiles = new List<string>();

			//path passed in is a File
			if (File.Exists(targetDirectory) && targetFileExtensions.Contains(Path.GetExtension(targetDirectory)))
			{
				targetFiles.Add(targetDirectory);
			}
			//path passed in is a directory
			else if (Directory.Exists(targetDirectory))
			{
				targetFiles = Directory
				.GetFiles(targetDirectory, "*.*", SearchOption.AllDirectories)
				.Where(file => targetFileExtensions.Any(file.ToLower().EndsWith))
				.ToList();
			}

			return targetFiles;
		}

		public static List<string> GetTargetPathsFromFile(string filename)
		{
			//read target directories from user created/input text file
			return File.ReadLines(filename).ToList();
		}

		public static List<string> GetTargetFileExtensions(char delimiter, string targetFileExtensions)
		{
			//take user input field string for target extensions, and convert it to List<string>. Trim whitespace between elements.
			return targetFileExtensions.Split(delimiter).Select(element => element.Trim()).ToList();
		}
	}
}

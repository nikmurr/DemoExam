using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LopushokModule
{
    public static class FilePicker
    {
        public static string GetPic(string? filepath)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            DirectoryInfo parentDirectory = Directory.GetParent(baseDirectory);

            if (parentDirectory != null)
            {
                DirectoryInfo grandParentDirectory = parentDirectory.Parent;

                if (grandParentDirectory != null)
                {
                    DirectoryInfo ggrandParentDirectory = grandParentDirectory.Parent;
                    if (ggrandParentDirectory != null)
                    {
                        DirectoryInfo gggrandParentDirectory = ggrandParentDirectory.Parent;
                        if (filepath == null || filepath == "")
                        {
                            return Path.Combine(gggrandParentDirectory.FullName, $"Resources\\picture.png");
                        }
                        else
                        {
                            return Path.Combine(gggrandParentDirectory.FullName, $"Resources\\{filepath}");
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

    }
}


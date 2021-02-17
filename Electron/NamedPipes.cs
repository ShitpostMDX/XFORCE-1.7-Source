using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace XFORCE.Electron
{
    internal class NamedPipes
    {
        public static string luapipename = "EPipe";

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool WaitNamedPipe(string name, int timeout);

        public static bool NamedPipeExist(string pipeName)
        {
            try
            {
                if (!NamedPipes.WaitNamedPipe("\\\\.\\pipe\\" + pipeName, 0))
                {
                    switch (Marshal.GetLastWin32Error())
                    {
                        case 0:
                            return false;
                        case 2:
                            return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void LuaPipe(string script)
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                new Thread((ThreadStart)(() =>
                {
                    try
                    {
                        using (NamedPipeClientStream pipeClientStream = new NamedPipeClientStream(".", NamedPipes.luapipename, PipeDirection.Out))
                        {
                            pipeClientStream.Connect();
                            using (StreamWriter streamWriter = new StreamWriter((Stream)pipeClientStream, Encoding.Default, 999999))
                            {
                                streamWriter.Write(script);
                                streamWriter.Dispose();
                            }
                            pipeClientStream.Dispose();
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Can't connect with ROBLOX", "Xurus | API Loader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debug |" + ex.Message, "Xurus | API Loader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                })).Start();
            }
            else
            {
                MessageBox.Show("First inject!", "Xurus | API Loader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

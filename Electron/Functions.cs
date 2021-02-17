using Microsoft.Win32;
using System;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace XFORCE.Electron
{
    internal class Functions
    {
        public static string exploitdllname = "ElectronDll.dll";

        public static void Inject()
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                MessageBox.Show("Already injected", "Xurus | API Loader", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
                    return;
                switch (Injector.DllInjector.GetInstance.Inject("RobloxPlayerBeta", AppDomain.CurrentDomain.BaseDirectory + Functions.exploitdllname))
                {
                    case Injector.DllInjectionResult.DllNotFound:
                        MessageBox.Show("Can't found ElectronDLL.dll", "Xurus | API Loader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case Injector.DllInjectionResult.GameProcessNotFound:
                        MessageBox.Show("Xurus can't found ROBLOX process", "Xurus | API Loader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case Injector.DllInjectionResult.InjectionFailed:
                        MessageBox.Show("Injection failed!", "Xurus | API Loader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        Thread.Sleep(3000);
                        if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
#pragma warning disable CS0642 // Posible instrucción vacía errónea
                            ;
#pragma warning restore CS0642 // Posible instrucción vacía errónea
                        break;


                }
            }
        }
    }
}

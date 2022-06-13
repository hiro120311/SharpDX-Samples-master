﻿using System;
using SharpDX.Windows;

namespace HelloConstBuffers
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var form = new RenderForm("Hello Constant Buffer")
            {
                Width = 1280,
                Height = 800
            };
            form.Show();

            using (var app = new HelloConstBuffers())
            {
                app.Initialize(form);

                using (var loop = new RenderLoop(form))
                {
                    while (loop.NextFrame())
                    {
                        app.Update();
                        app.Render();
                    }
                }
            }
        }
    }
}

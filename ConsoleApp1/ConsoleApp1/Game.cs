using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using static System.Net.Mime.MediaTypeNames;


namespace ConsoleApp1
{
        
    public class Game : GameWindow
    {
        private Shader shader;

        private float Speed = 1.5f;
        private bool FirstMove = true;

        private double time=0;

        private Vector3 Position;
        private Vector3 Front;
        private Vector3 Up;


        private Matrix4 view;
        private Matrix4 projection;

        private float Pitch=0.0f;
        private float Yaw=0.0f;
        private float Sensitivity=0.1f;

        Scene main_scene = new();

        public Game(int width, int height, string title) : base(GameWindowSettings.Default, new NativeWindowSettings() { Size = (width, height), Title = title })
        {
        }
        //Executes one time when the program executes
        protected override void OnLoad()
        {   
            base.OnLoad();

            
            //ObjectJsonator.Serialize();

            MousePosition = new Vector2(Size.X / 2f, Size.Y / 2f);

            GL.ClearColor(0.8f, 0.7f, 0.3f, 1.0f);
            GL.Enable(EnableCap.DepthTest);

            CursorState = CursorState.Grabbed;


            Position = new Vector3(0.0f, 0.0f, 3.0f);
            Front = new Vector3(0.0f, 0.0f, -1.0f);
            Up = Vector3.UnitY;


            main_scene.Objects.Add("monitor", LoadObject("monitor", 0.0f, 0.75f, 0.0f));
            main_scene.Objects.Add("desk", LoadObject("desk", 0.0f, 0.75f, 0.0f));
            main_scene.Objects.Add("chair", LoadObject("chair", 0.0f, 0.75f, 0.0f));

            //use the shader
            shader = new Shader("../../../shaders/shader.vert", "../../../shaders/shader.frag");

            //creates a perspective type
            view = Matrix4.LookAt(Position, Position + Front, Up);
            projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(90f), Size.X / (float)Size.Y, 0.1f, 100.0f);

            

        }

        //Executes when rendering
        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);

            time +=args.Time;

            view = Matrix4.LookAt(Position, Position + Front, Up);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            main_scene.draw(shader, Matrix4.Identity,view,projection,time);

            

            SwapBuffers();


        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            if (!IsFocused) // Check to see if the window is focused
            {
                return;
            }

            var input = KeyboardState;

            if (input.IsKeyDown(Keys.Escape))
            {
                Close();
            }



            if (input.IsKeyDown(Keys.W))
            {
                Position += Front * Speed * (float)e.Time; // Forward
            }

            if (input.IsKeyDown(Keys.S))
            {
                Position -= Front * Speed * (float)e.Time; // Backwards
            }
            if (input.IsKeyDown(Keys.A))
            {
                Position -= Vector3.Normalize(Vector3.Cross(Front, Up)) * Speed * (float)e.Time; // Left
            }
            if (input.IsKeyDown(Keys.D))
            {
                Position += Vector3.Normalize(Vector3.Cross(Front, Up)) * Speed * (float)e.Time; // Right
            }
            if (input.IsKeyDown(Keys.Space))
            {
                Position += Up * Speed * (float)e.Time; // Up
            }
            if (input.IsKeyDown(Keys.LeftShift))
            {
                Position -=Up * Speed * (float)e.Time; // Down
            }


        }


        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            base.OnMouseMove(e);
            if (IsFocused)
            {
                Vector2 center = new Vector2(Size.X / 2f, Size.Y / 2f);
                if (FirstMove)
                {
                    FirstMove = false;
                    return;
                }


                float deltaX = MousePosition.X - center.X;
                float deltaY = MousePosition.Y - center.Y;
                Yaw += deltaX * Sensitivity;
                Pitch -= deltaY * Sensitivity;

                if (Pitch > 89.0f)
                {
                    Pitch = 89.0f;
                }
                else if (Pitch < -89.0f)
                {
                    Pitch = -89.0f;
                }

                Front.X = (float)Math.Cos(MathHelper.DegreesToRadians(Pitch)) * (float)Math.Cos(MathHelper.DegreesToRadians(Yaw));
                Front.Y = (float)Math.Sin(MathHelper.DegreesToRadians(Pitch));
                Front.Z = (float)Math.Cos(MathHelper.DegreesToRadians(Pitch)) * (float)Math.Sin(MathHelper.DegreesToRadians(Yaw));
                Front = Vector3.Normalize(Front);

                MousePosition = new Vector2(Size.X / 2f, Size.Y / 2f);
            }
        }



        protected override void OnFramebufferResize(FramebufferResizeEventArgs e)
        {
            base.OnFramebufferResize(e);
            projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(90f), Size.X / (float)Size.Y, 0.1f, 100.0f);
            GL.Viewport(0, 0, Size.X, Size.Y);
        }


        private Object3D LoadObject(string name, float offset_x = 0.0f, float offset_y = 0.0f, float offset_z = 0.0f)
        {
            using (StreamReader sr = File.OpenText("../../../assets/objects/" + name + ".json"))
            {
                Object3D objectOut = JsonConvert.DeserializeObject<Object3D>(sr.ReadToEnd());
                objectOut.offset_x = offset_x;
                objectOut.offset_y = offset_y;
                objectOut.offset_z = offset_z;
                return objectOut;
            }
        }
    }
}


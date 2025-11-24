using OpenTK.Graphics.OpenGL;
using System;

namespace OpenTK_winforms_z02
{
    internal class Light
    {
        private float[] _ambient = new float[4];
        private float[] _diffuse = new float[4];
        private float[] _specular = new float[4];
        private float[] _position = new float[4];

        public LightName Name { get; private set; }
        public bool On { get; set; }

        public float[] Ambient
        {
            get { return _ambient; }
            set
            {
                if (value != null && value.Length == 4)
                {
                    Array.Copy(value, _ambient, 4);
                }
            }
        }

        public float[] Diffuse
        {
            get { return _diffuse; }
            set
            {
                if (value != null && value.Length == 4)
                {
                    Array.Copy(value, _diffuse, 4);
                }
            }
        }

        public float[] Specular
        {
            get { return _specular; }
            set
            {
                if (value != null && value.Length == 4)
                {
                    Array.Copy(value, _specular, 4);
                }
            }
        }

        public float[] Position
        {
            get { return _position; }
            set
            {
                if (value != null && value.Length == 4)
                {
                    Array.Copy(value, _position, 4);
                }
            }
        }
        public Light(LightName name, float[] ambient, float[] diffuse, float[] specular, float[] position)
        {
            Name = name;
            On = false;

            Ambient = ambient;
            Diffuse = diffuse;
            Specular = specular;
            Position = position;
        }

        public void applyValues()
        {
            GL.Light(Name, LightParameter.Ambient, _ambient);
            GL.Light(Name, LightParameter.Diffuse, _diffuse);
            GL.Light(Name, LightParameter.Specular, _specular);
            GL.Light(Name, LightParameter.Position, _position);

            if (On)
            {
                GL.Enable((EnableCap)Name);
            }
            else
            {
                GL.Disable((EnableCap)Name);
            }
        }
    }
}
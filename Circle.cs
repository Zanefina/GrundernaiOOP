using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaiOOP
{
    class Circle
    {
        float _pi;
        int _Radius;

        public Circle(float Pi, int Radius)
        {
            this._pi = Pi;
            this._Radius = Radius;
        }
        public float GetArea()
        {
            float area = _Radius * _Radius * _pi;
            return area;
        }
        public float GetVolume()
        {
            float volume = (4* _pi * _Radius * _Radius * _Radius) / 3;
            return volume;
        }
    }
}

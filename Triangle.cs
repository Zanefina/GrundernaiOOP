using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaiOOP
{
    class Triangle
    {
        float _base;//variable for triangle's basement.
        float _height;//variable for triangle's height.
        public Triangle(float Base, float Height)//Constructor.
        {
            this._base = Base;
            this._height = Height;
        }
        public float GetArea()//A method to get the triangle's area.
        {
            float area = (_base * _height)/2;
            return area;
        }
        public float GetVolume()//A method to get the triangle's volume.
        {
            float volume =(_base * _height * _height)/3;
            return volume;
        }
    }
}

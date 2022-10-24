using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaiOOP
{
    class Circle
    {
        float _pi; //variable pi-
        int _Radius;//variable radius

        public Circle(float Pi, int Radius) 
    //Constructor.This is a special method that is used to automatically create an object and
    //to initialize all the class data members.
        {
            this._pi = Pi;
            this._Radius = Radius;
        }
        public float GetArea()//A method to get the circle's area.
        {
            float area = _Radius * _Radius * _pi;
            return area;
        }
        public float GetVolume()//A method to get the circle's volume.
        {
            float volume = (4* _pi * _Radius * _Radius * _Radius) / 3;
            return volume;
        }
    }
}

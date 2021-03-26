using System;
namespace Shapes
{
    public class Shapes
    {
        public Shapes()
        {

        }
        public void help()
        {
            Console.WriteLine(@"
                All commands display the given information about each class:
                * Drawing
                * Equations
                * Other
                Command List:
                rec - rectange
                cir - circle
                tri - triangle
                trap - trapezoid
");
        }
        public void rec()
        {
            Console.WriteLine(@"
            _________________
            |               | ^
            |               | | width (w)
            |               | |
            |_______________| V
            <--------------->
                length (l)
            Sides: 4
            Area = l * w
            Perimeter = (2l) * (2w)
            *A square is a rectangle, but a rectangle is not a square.
");
        }
        public void cir()
        {
            Console.WriteLine(@"
                     ***
                  **     **
                *<--------->* diameter (d)
                  **     **
                      *
            Sides: 0 (or infinity)
            Radius = 1/2 (d)
            Area = 2(pi)r^2
            Circumference = 2(pi)r
            *Pi is the number that is related to circles, thus why the number is never ending
");
        }
        public void tri()
        {
            Console.WriteLine(@"
                    /\      ^
                   /  \     |
                  /    \    | height (h)
                 /      \   |
                /________\  V
                <-------->
                   base
            Sides: 3
            Area = 1/2(base) * (height)
            *Two triangles can be placed in suych a way that creates a rectangle
");
        }
        public void trap()
        {
            Console.WriteLine(@"
                <--------->
                _____a_____     ^
               /           \    | height (h)
              /             \   |
             /_______________\  V
             <-------b------->
            Sides: 4
            Area = [(a + b) / 2] * h
            *Side a and b are complete independent of each other, as long as a is not equal to b
");
        }
    }
}
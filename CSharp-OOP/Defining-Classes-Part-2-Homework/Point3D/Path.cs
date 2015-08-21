using System;
using System.Collections.Generic;

namespace Point3D
{
    class Path
    {
        private List<Point3D> sequence;

        public Path()
        {
            this.sequence = new List<Point3D>();
        }

        public List<Point3D> Sequence
        {
            get
            {
                return this.sequence;
            }
            private set
            {
                this.sequence = value;
            }
        }
    }
}

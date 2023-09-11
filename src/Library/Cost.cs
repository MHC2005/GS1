//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Cost
    {
        public Cost(int materialCost, int equipmentCost)
        {
            this.Description = Description;
            this.HourlyCost = HourlyCost;
        }

        public string Description { get; set; }

        public double HourlyCost { get; set; }
    }
}
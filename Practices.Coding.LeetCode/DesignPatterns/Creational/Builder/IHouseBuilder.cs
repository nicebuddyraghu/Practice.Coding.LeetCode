﻿namespace Practices.Coding.LeetCode.DesignPatterns.Creational.Builder
{
    public interface IHouseBuilder
    {
        void BuildFoundation();
        void BuildPillars();
        void BuildWalls();
        void BuildRoof();
        void BuildRooms();
        IHouse GetHouse();
    }
}

﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using SquareEmpire.model.team;
using SquareEmpire.models.unit.warrior;

namespace SquareEmpire.model.generator
{
    public class TestGameGenerator : IGameGenerator
    {
        public SquareEmpireGame GenerateGame()
        {
            var teams = new List<Team>
            {
                new Team(Color.Red),
                new Team(Color.Blue)
            }.ToImmutableList();

            var cells = new MapCell[5, 10];
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    cells[i, j] = new MapCell(null, teams[0]);
                }

                for (var j = 5; j < 10; j++)
                {
                    cells[i, j] = new MapCell(null, teams[1]);
                }
            }

            cells[0, 4].Unit = new DefaultWarrior();
            cells[1, 4].Unit = new DefaultWarrior();
            cells[2, 4].Unit = new DefaultWarrior();
            cells[3, 4].Unit = new DefaultWarrior();
            
            cells[0, 5].Unit = new DefaultWarrior();
            cells[1, 5].Unit = new DefaultWarrior();
            cells[2, 5].Unit = new DefaultWarrior();

            return new SquareEmpireGame(cells, teams, teams[1]);
        }
    }
}
using System;

namespace GraphGeneratorLibrary
{
    public class GraphGenerator
    {
        private int quantityOfVertices;
        private string graphLayout;
            
        public int [,] GenerateRandomGraph()
        { 
            int [,] graph = new int[this.quantityOfVertices, this.quantityOfVertices];
        
            for(int line = 0; line < graph.GetLength(0); line++)
            {
                for(int column = 0; column < graph.GetLength(1); column++)
                {                                
                    graph[line, column] = ((column == line) ? 0 : (column > line) ? new Random().Next(2) : graph[column, line]);                
                }
            }                          
            return graph;
        }

        public string GenerateGraphLayout(int [,] graph)
        {
            for(int line = 0; line < graph.GetLength(0); line++)
            {
                for(int column = 0; column < graph.GetLength(1); column++)
                {
                    graphLayout += graph[line, column] + "  ";
                }
                graphLayout+= "\n";
            }
            return this.graphLayout;
        }
        
        public int QuantityOfVertices {get => this.quantityOfVertices; set => this.quantityOfVertices = value;}
    }
}

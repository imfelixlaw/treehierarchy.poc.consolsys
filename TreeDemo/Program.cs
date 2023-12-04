using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // prepare data to create tree
            var data = PrepareData();

            // create the tree
            var rootNodes = Node<TreeItemDto>.CreateTree(data, l => l.Id, l => l.Parent);

            // display the tree
            PrintScreen(rootNodes);
            
            Console.ReadKey();
        }

        private static void PrintScreen(IEnumerable<Node<TreeItemDto>> treeItems)
        {
            // sort it by order
            foreach (var t in treeItems.OrderBy(x => x.Value.Order))
            {
                for (int i = 0; i < t.Level; i++)
                    Console.Write(" ");
                Console.Write(t.Value.Title);
                Console.Write("\t\t\t\t\t\t\t\t");
                Console.Write(t.Value.SomeValue1);
                Console.WriteLine();
                if (t.Children.Count() > 0)
                    PrintScreen(t);
            }
        }

        private static IEnumerable<TreeItemDto> PrepareData()
        {
            var item = new List<TreeItemDto>();

            item.Add(new TreeItemDto { Id = 1, Order = 1, Parent = null, Title = "Root Item 1" });
            item.Add(new TreeItemDto { Id = 2, Order = 2, Parent = null, Title = "Root Item 2" });
            item.Add(new TreeItemDto { Id = 3, Order = 3, Parent = null, Title = "Root Item 3" });
            item.Add(new TreeItemDto { Id = 4, Order = 4, Parent = null, Title = "Root Item 4" });
            item.Add(new TreeItemDto { Id = 5, Order = 5, Parent = null, Title = "Root Item 5" });
            item.Add(new TreeItemDto { Id = 6, Order = 6, Parent = null, Title = "Root Item 6" });

            item.Add(new TreeItemDto { Id = 7, Order = 1, Parent = 1, Title = "Item 1 for Root Item 1", SomeValue1 = "AB 11 C 123" });
            item.Add(new TreeItemDto { Id = 8, Order = 2, Parent = 1, Title = "Item 2 for Root Item 1", SomeValue1 = "AB 12 C 123" });
            item.Add(new TreeItemDto { Id = 9, Order = 3, Parent = 1, Title = "Item 3 for Root Item 1", SomeValue1 = "AB 13 C 123" });
            item.Add(new TreeItemDto { Id = 10, Order = 4, Parent = 1, Title = "Item 4 for Root Item 1", SomeValue1 = "AB 14 C 123" });
            item.Add(new TreeItemDto { Id = 11, Order = 5, Parent = 1, Title = "Item 5 for Root Item 1", SomeValue1 = "AB 15 C 123" });
            item.Add(new TreeItemDto { Id = 12, Order = 6, Parent = 1, Title = "Item 6 for Root Item 1", SomeValue1 = "AB 16 C 123" });

            item.Add(new TreeItemDto { Id = 13, Order = 1, Parent = 3, Title = "Item 1 for Root Item 3" });
            item.Add(new TreeItemDto { Id = 14, Order = 2, Parent = 3, Title = "Item 2 for Root Item 3" });
            item.Add(new TreeItemDto { Id = 15, Order = 3, Parent = 3, Title = "Item 3 for Root Item 3" });

            item.Add(new TreeItemDto { Id = 16, Order = 1, Parent = 3, Title = "Item 1 for Root Item 5", SomeValue1 = "ABC 5 1 123" });
            item.Add(new TreeItemDto { Id = 17, Order = 2, Parent = 3, Title = "Item 2 for Root Item 5", SomeValue1 = "ABC 5 2 123" });
            item.Add(new TreeItemDto { Id = 18, Order = 3, Parent = 3, Title = "Item 3 for Root Item 5", SomeValue1 = "ABC 5 3 123" });

            item.Add(new TreeItemDto { Id = 19, Order = 1, Parent = 7, Title = "Item 1 for Item 1 in Root Item 1" });

            return item;
        }
    }
}

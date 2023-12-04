using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeDemo
{
    public class TreeItemDto : ITreeItemDto
    {
        #region Interface Member cannot change

        public int Id { get; set; }

        public int Order { get; set; }

        public int? Parent { get; set; }
        #endregion

        public string Title { get; set; }

        public string SomeValue1 { get; set; }
    }

    public interface ITreeItemDto
    {
        // the tree id
        int Id { get; set; }

        // this is to sorting the order inside the list
        int Order { get; set; }

        // parent id
        int? Parent { get; set; }
    }
}

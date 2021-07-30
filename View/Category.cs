using System.Windows.Controls;

namespace View
{
    /// <summary>
    /// 목차 Class
    /// </summary>
    class Category
    {
        /// <summary>
        /// 목차명
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 사용자 컨트롤
        /// </summary>
        public UserControl Control { get; }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="name"> 목차명 </param>
        public Category(string name, UserControl control)
        {
            Name = name;
            Control = control;
        }
    }
}

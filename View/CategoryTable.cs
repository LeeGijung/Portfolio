using System.Collections.Generic;

namespace View
{
    /// <summary>
    /// 목차 설정 테이블 Class
    /// </summary>
    class CategoryTable
    {
        /// <summary>
        /// 목록 테이블
        /// </summary>
        public List<Category> Tables { get; }

        /// <summary>
        /// 생성자
        /// </summary>
        public CategoryTable()
        {
            Tables = new List<Category>();

            Tables.Add(new Category("기본 사항 입력", new Foundation()));
        }
    }
}

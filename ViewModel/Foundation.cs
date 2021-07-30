namespace ViewModel
{
    public class Foundation
    {
        /// <summary>
        /// 한글 이름
        /// </summary>
        public string KoreanName { get;  set; }

        /// <summary>
        /// 영문 이름
        /// </summary>
        public string EnglishName { get; set; }

        /// <summary>
        /// 나이
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 비즈니스 로직 수행
        /// </summary>
        public void Run()
        {
            Model.Foundation foundation = new Model.Foundation();
            foundation.Run(KoreanName, EnglishName, Age);
        }
    }
}

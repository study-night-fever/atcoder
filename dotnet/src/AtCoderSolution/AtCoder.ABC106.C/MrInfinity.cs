namespace AtCoder.ABC106.C
{
    public class MrInfinity
    {
        public string Answer(string S, long K)
        {
            for (var i = 0; i < K && i < S.Length; i++)
            {
                var s = S[i].ToString();

                if (s != "1")
                {
                    // 1以外の文字が出現したらそれが答え
                    return s;
                }
            }
            // 位置Kまで1しかなかった
            return "1";
        }
    }
}

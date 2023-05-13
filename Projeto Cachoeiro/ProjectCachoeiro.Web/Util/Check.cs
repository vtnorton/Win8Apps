namespace ProjectCachoeiro.Web.Util
{
    public static class Check
    {
        public static bool EhDoDominio(string email)
        {
            email = email.ToLower().Trim();
            return email.EndsWith("@vtnorton.com") || email.EndsWith("@danzi.com.br") || email.EndsWith("omie.com.br");
        }
    }
}

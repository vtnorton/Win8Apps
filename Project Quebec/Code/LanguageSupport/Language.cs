namespace ProjectQuebec.Code.LanguageSupport
{
    public class Language
    {
        public int Id { get; set; }
        public bool ThereIsHint { get; set; }
        public string Alias { get; set; }
        public string Hint { get; set; }
        public string Mode { get; set; }
        public string Name { get; set; }
        public string[] SampleImageURI { get; set; }
        public string[] SampleURI { get; set; }
        public string[] SampleTitle { get; set; }
        public string[] SampleExtention { get; set; }
        public string[] Extention { get; set; }
        public string[] Mime { get; set; }
        
    }
}

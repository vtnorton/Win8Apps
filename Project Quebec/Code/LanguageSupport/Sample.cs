namespace ProjectQuebec.Code.LanguageSupport
{
    public class Sample
    {
        public string Name { get; set; }
        public string SampleURI { get; set; }
        public string SampleImageURI { get; set; }
        public string SampleExtention { get; set; }
        public string SampleDescription
        {
            get
            {
                return this.SampleExtention;
            }
            set
            {
                this.SampleExtention = value + " file";
            }
        }
        public string LanguageName{ get; set; }
        public Language SampleLanguage {get; set;}
    }
}

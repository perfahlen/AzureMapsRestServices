namespace AzureMapsToolkit.Timezone
{
    public class Timezone
    {
        public string[] Aliases { get; set; }

        public Country[] Countries { get; set; }

        public string Id { get; set; }

        public Names Names { get; set; }

        public ReferenceTime ReferenceTime { get; set; }

        public RepresentativePoint RepresentativePoint { get; set; }

        public TimeTransition[] TimeTransitions { get; set; }

    }
}

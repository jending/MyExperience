namespace MyExperienceWebApp
{
    public static class DataSource
    {
        public static List<DataSourceItem> GetData()
        {
            return new List<DataSourceItem>()
            {
                new DataSourceItem()
                {
                    MainTextHtml = "I do NOT like same-day plans.",
                    SubTextHtml = "<b>Please</b> do not attempt to make last-minute plans with me unless there is a special occasion."
                },
                new DataSourceItem()
                {
                    MainTextHtml = "It is very difficult to respond sometimes to people who reach out."
                },
                new DataSourceItem()
                {
                    MainTextHtml = "My body panics at the slightest stresses.",
                    SubTextHtml = "Instant physical manifestations of this panic include...",
                    ImagePaths = null, //todo
                    PostImageText = "I generally maintain decent control over my outward appearance, so often this subtle panic is not easily visible to onlookers. The occasional yelling-meltdown happens if I am feeling stressed and tired enough and the environment is safe enough for me to release a bit of rage..."
                },
                new DataSourceItem()
                {
                    MainTextHtml = "It can be very difficult for me to process particular sounds or many sounds at once. For example:",
                    ImagePaths = new List<string>
                    {
                        "SoundProcessingExample_1.png",
                        "SoundProcessingExample_2.png"
                    } 
                },
                new DataSourceItem()
                {
                    MainTextHtml = "I <b>hate</b> lights. I cannot stand having a direct source of light in my line of sight (this includes the sun, especially). My favourite type of lighting is indirect sunlight through windows.",
                    SubTextHtml = "<ul><li>This can make driving difficult (especially on wet,reflective roads).</li><li>I <b>particularly</b> dislike <span class='blue-lights-demo'>blue lights.</span></li></ul>"
                },
                new DataSourceItem()
                {
                    MainTextHtml = "I have many of the <small><small>tiniest</small></small> stress triggers that put my body in that state of subtle panic explained above, including but not limited to...",
                    ImagePaths = null, //todo
                },
                new DataSourceItem()
                {
                    MainTextHtml = "Ambiguous wording can be tough for me often.",
                    SubTextHtml = "Difficulty understanding people sometimes has lead to jokes about being airheaded, meanwhile I'm usually just sitting there iterating in my head through the different possible meanings based on the wording used..."
                },
                new DataSourceItem()
                {
                    MainTextHtml = "I don't feel any sensitivities while maintaining eye-contact with Jay and my direct family members... however I <b>do</b> feel incredibly sensitive while maintaining eye-contact with <b>most</b> other people.",
                    SubTextHtml = "<ul><li>It can be so exhilerating to the point of being overwhelming-- sometimes just a few seconds of eye-contact will leave my heart racing for days.</li><li>That isn't to say I cannot hold eye-contact-- I will just be absorbing little of the conversation while doing so. Therefore please don't think I hate you if I don't look at you much while conversing-- I'm trying to stay focused.</li></ul>"
                },
                new DataSourceItem()
                {
                    MainTextHtml = "Most of the expressions you see me use while conversing are calculated and forced. I am very good at this, however it is very tiring and often uncomfortable to keep up for long (my face ends up in pain and I am likely to get a tension headache). I go to efforts to respond to people expressively because...",
                    ImagePaths = null //todo
                },
                new DataSourceItem()
                {
                    MainTextHtml = "I feel an uncontrollable need to escape the company of <b>most</b> people seeking my company. If I avoid being near you, it is likely not (entirely) personal."
                },
                new DataSourceItem()
                {
                    MainTextHtml = "<b>I hate pants.</b> I try not to wear them if I can. My favourite leg covering to wear is leotards, because they are the farthest I can get from pants while still covering my legs.",
                    SubTextHtml = "People really seem to take it personally when I wear leotards in the winter..."
                },
                new DataSourceItem()
                {
                    MainTextHtml = "I don't feel social connections very deeply.",
                    SubTextHtml = "I like being around people, making people feel good, and being appreciated by other people-- however rarely do I feel any kind of bond strong enough to pursue friendship."
                },
                new DataSourceItem()
                {
                    MainTextHtml = "I am <b>very</b> rarely sarcastic.",
                    SubTextHtml = "People often seem to assume I am speaking sarcastically when I am speaking sincerely."
                },
                new DataSourceItem()
                {
                    MainTextHtml = "<b>Please</b> don't ask my opinion unless you're certain a possible negative one will be constructive. I hate seeing the fall in someone's face when I am not able to tell them what they are hoping to hear."
                },
                new DataSourceItem()
                {
                    MainTextHtml = "Although Autism is generally connected with lack of empathy, this is <b>not</b> the case for me.",
                    SubTextHtml = "It actually feels like my empathy meter is on <i>constant</i> overdrive."
                },
                new DataSourceItem()
                {
                    MainTextHtml = "I find comfort in some repetitive behaviours, including...",
                    ImagePaths = null, //todo
                },
                new DataSourceItem()
                {
                    MainTextHtml = "I often spend <b>hours</b> studying conversations I've had with other people, determining whether or not each conversation was \"successful\", and obsessing over both what did and what did not go well."
                },
                new DataSourceItem()
                {
                    MainTextHtml = "I have had issues with reading the room and blurting out hurtful things to people, only realizing the severity of my comment after the damage has been done.",
                    SubTextHtml = "I try to speak in a more guarded manner now, in effort not to accidentally hurt feelings of the people around me. "
                }
            };
        }
    }

    public class DataSourceItem
    {
        public string MainTextHtml { get; set; }
        public string SubTextHtml { get; set; }
        public List<string> ImagePaths { get; set; }
        public string PostImageText { get; set; }
    }
}

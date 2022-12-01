using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentMeetingPlannerContext>>()))
            {
                if (context == null)
                {
                    throw new ArgumentNullException("Null SacramentMeetingPlannerlContext");
                }

                // Look for any hymns.
                if (context.Hymn.Any())
                {
                    return;   // DB has been seeded
                }

                context.Hymn.AddRange(
                    new Hymn
                    {
                        HymnNumber = 1,
                        HymnTitle = "The Morning Breaks"
                    },

                    new Hymn
                    {
                        HymnNumber = 2,
                        HymnTitle = "The Spirit of God"
                    },

                    new Hymn
                    {
                        HymnNumber = 3,
                        HymnTitle = "Now Let Us Rejoice"
                    },

                    new Hymn
                    {
                        HymnNumber = 4,
                        HymnTitle = "Truth Eternal"
                    },

                    new Hymn
                    {
                        HymnNumber = 5,
                        HymnTitle = "High on the Mountain Top"
                    },

                    new Hymn
                    {
                        HymnNumber = 6,
                        HymnTitle = "Redeemer of Israel"
                    },

                    new Hymn
                    {
                        HymnNumber = 7,
                        HymnTitle = "Israel, Israel, God is Calling"
                    },

                    new Hymn
                    {
                        HymnNumber = 8,
                        HymnTitle = "Awake and Arise"
                    },

                    new Hymn
                    {
                        HymnNumber = 9,
                        HymnTitle = "Come, Rejoice"
                    },

                    new Hymn
                    {
                        HymnNumber = 10,
                        HymnTitle = "Come, Sing to the Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 11,
                        HymnTitle = "What Was Witnessed in the Heavens?"
                    },

                    new Hymn
                    {
                        HymnNumber = 12,
                        HymnTitle = "'Twas Witnessed in the Heavens"
                    },

                    new Hymn
                    {
                        HymnNumber = 13,
                        HymnTitle = "An Angel from on High"
                    },

                    new Hymn
                    {
                        HymnNumber = 14,
                        HymnTitle = "Sweet is the Peace the Gospel Brings"
                    },

                    new Hymn
                    {
                        HymnNumber = 15,
                        HymnTitle = "I Saw a Mighty Angel Fly"
                    },

                    new Hymn
                    {
                        HymnNumber = 16,
                        HymnTitle = "What Glorious Scenes Mine Eyes Behold"
                    },

                    new Hymn
                    {
                        HymnNumber = 17,
                        HymnTitle = "Awake, Ye Saints of God, Awake"
                    },

                    new Hymn
                    {
                        HymnNumber = 18,
                        HymnTitle = "The Voice of God Again is Heard"
                    },

                    new Hymn
                    {
                        HymnNumber = 19,
                        HymnTitle = "We Thank Thee, O God, for a Prophet"
                    },

                    new Hymn
                    {
                        HymnNumber = 20,
                        HymnTitle = "God of Power, God of Right"
                    },

                    new Hymn
                    {
                        HymnNumber = 21,
                        HymnTitle = "Come, Listen to a Prophet's Voice"
                    },

                    new Hymn
                    {
                        HymnNumber = 22,
                        HymnTitle = "We Listen to a Prophet's Voice"
                    },

                    new Hymn
                    {
                        HymnNumber = 23,
                        HymnTitle = "We Ever Pray for Thee"
                    },

                    new Hymn
                    {
                        HymnNumber = 24,
                        HymnTitle = "God Bless Our Prophet Dear"
                    },

                    new Hymn
                    {
                        HymnNumber = 25,
                        HymnTitle = "Now We'll Sing with One Accord"
                    },

                    new Hymn
                    {
                        HymnNumber = 26,
                        HymnTitle = "Joseph Smith's First Prayer"
                    },

                    new Hymn
                    {
                        HymnNumber = 27,
                        HymnTitle = "Praise to the Man"
                    },

                    new Hymn
                    {
                        HymnNumber = 28,
                        HymnTitle = "Saints, Behold How Great Jehovah"
                    },

                    new Hymn
                    {
                        HymnNumber = 29,
                        HymnTitle = "A Poor Wayfaring Man of Grief"
                    },

                    new Hymn
                    {
                        HymnNumber = 30,
                        HymnTitle = "Come, Come, Ye Saints"
                    },

                    new Hymn
                    {
                        HymnNumber = 31,
                        HymnTitle = "O God, Our Help in Ages Past"
                    },

                    new Hymn
                    {
                        HymnNumber = 32,
                        HymnTitle = "The Happy Day at Last Has Come"
                    },

                    new Hymn
                    {
                        HymnNumber = 33,
                        HymnTitle = "Our Mountain Home So Dear"
                    },

                    new Hymn
                    {
                        HymnNumber = 34,
                        HymnTitle = "O Ye Mountains High"
                    },

                    new Hymn
                    {
                        HymnNumber = 35,
                        HymnTitle = "For the Strength of the Hills"
                    },

                    new Hymn
                    {
                        HymnNumber = 36,
                        HymnTitle = "They, the Builders of the Nation"
                    },

                    new Hymn
                    {
                        HymnNumber = 37,
                        HymnTitle = "The Wintry Day, Descending to Its Close"
                    },

                    new Hymn
                    {
                        HymnNumber = 38,
                        HymnTitle = "Come, All Ye Saints of Zion"
                    },

                    new Hymn
                    {
                        HymnNumber = 39,
                        HymnTitle = "O Saints of Zion"
                    },

                    new Hymn
                    {
                        HymnNumber = 40,
                        HymnTitle = "Arise, O Glorious Zion"
                    },

                    new Hymn
                    {
                        HymnNumber = 41,
                        HymnTitle = "Let Zion in Her Beauty Rise"
                    },

                    new Hymn
                    {
                        HymnNumber = 42,
                        HymnTitle = "Hail to the Brightness of Zion's Glad Morning!"
                    },

                    new Hymn
                    {
                        HymnNumber = 43,
                        HymnTitle = "Zion Stands with Hills Surrounded"
                    },

                    new Hymn
                    {
                        HymnNumber = 44,
                        HymnTitle = "Beautiful Zion, Built Above"
                    },

                    new Hymn
                    {
                        HymnNumber = 45,
                        HymnTitle = "Lead Me into Life Eternal"
                    },

                    new Hymn
                    {
                        HymnNumber = 46,
                        HymnTitle = "Glorious Things of Thee Are Spoken"
                    },

                    new Hymn
                    {
                        HymnNumber = 47,
                        HymnTitle = "We Will Sing of Zion"
                    },

                    new Hymn
                    {
                        HymnNumber = 48,
                        HymnTitle = "Glorious Things Are Sung of Zion"
                    },

                    new Hymn
                    {
                        HymnNumber = 49,
                        HymnTitle = "Adam-ondi-Ahman"
                    },

                    new Hymn
                    {
                        HymnNumber = 50,
                        HymnTitle = "Come, Thou Glorious Day of Promise"
                    },

                    new Hymn
                    {
                        HymnNumber = 51,
                        HymnTitle = "Sons of Michael, He Approaches"
                    },

                    new Hymn
                    {
                        HymnNumber = 52,
                        HymnTitle = "The Day Dawn Is Breaking"
                    },

                    new Hymn
                    {
                        HymnNumber = 53,
                        HymnTitle = "Let Earth's Inhabitants Rejoice"
                    },

                    new Hymn
                    {
                        HymnNumber = 54,
                        HymnTitle = "Behold, the Mountain of the Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 55,
                        HymnTitle = "Lo, the Mighty God Appearing!"
                    },

                    new Hymn
                    {
                        HymnNumber = 56,
                        HymnTitle = "Softly Beams the Sacred Dawning"
                    },

                    new Hymn
                    {
                        HymnNumber = 57,
                        HymnTitle = "We're Not Ashamed to Own Our Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 58,
                        HymnTitle = "Come, Ye Children of the Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 59,
                        HymnTitle = "Come, O Thou King of Kings"
                    },

                    new Hymn
                    {
                        HymnNumber = 60,
                        HymnTitle = "Battle Hymn of the Republic"
                    },

                    new Hymn
                    {
                        HymnNumber = 61,
                        HymnTitle = "Raise Your Voices to the Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 62,
                        HymnTitle = "All Creatures of Our God and King"
                    },

                    new Hymn
                    {
                        HymnNumber = 63,
                        HymnTitle = "Great King of Heaven"
                    },

                    new Hymn
                    {
                        HymnNumber = 64,
                        HymnTitle = "On This Day of Joy and Gladness"
                    },

                    new Hymn
                    {
                        HymnNumber = 65,
                        HymnTitle = "Come, All Ye Saints Who Dwell on Earth"
                    },

                    new Hymn
                    {
                        HymnNumber = 66,
                        HymnTitle = "Rejoice, the Lord is King!"
                    },

                    new Hymn
                    {
                        HymnNumber = 67,
                        HymnTitle = "Glory to God on High"
                    },

                    new Hymn
                    {
                        HymnNumber = 68,
                        HymnTitle = "A Mighty Fortress is Our God"
                    },

                    new Hymn
                    {
                        HymnNumber = 69,
                        HymnTitle = "All Glory, Laud, and Honor"
                    },

                    new Hymn
                    {
                        HymnNumber = 70,
                        HymnTitle = "Sing Praise to Him"
                    },

                    new Hymn
                    {
                        HymnNumber = 71,
                        HymnTitle = "With Songs of Praise"
                    },

                    new Hymn
                    {
                        HymnNumber = 72,
                        HymnTitle = "Praise to the Lord, the Almighty"
                    },

                    new Hymn
                    {
                        HymnNumber = 73,
                        HymnTitle = "Praise the Lord with Heart and Voice"
                    },

                    new Hymn
                    {
                        HymnNumber = 74,
                        HymnTitle = "Praise Ye the Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 75,
                        HymnTitle = "In Hymns of Praise"
                    },

                    new Hymn
                    {
                        HymnNumber = 76,
                        HymnTitle = "God of Our Fathers, We Come unto Thee"
                    },

                    new Hymn
                    {
                        HymnNumber = 77,
                        HymnTitle = "Great Is the Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 78,
                        HymnTitle = "God of Our Fathers, Whose Almighty Hand"
                    },

                    new Hymn
                    {
                        HymnNumber = 79,
                        HymnTitle = "With All the Power of Heart and Tongue"
                    },

                    new Hymn
                    {
                        HymnNumber = 80,
                        HymnTitle = "God of Our Fathers, Known of Old"
                    },

                    new Hymn
                    {
                        HymnNumber = 81,
                        HymnTitle = "Press Forward, Saints"
                    },

                    new Hymn
                    {
                        HymnNumber = 82,
                        HymnTitle = "For All the Saints"
                    },

                    new Hymn
                    {
                        HymnNumber = 83,
                        HymnTitle = "Guide Us, O Thou Great Jehovah"
                    },

                    new Hymn
                    {
                        HymnNumber = 84,
                        HymnTitle = "Faith of Our Fathers"
                    },

                    new Hymn
                    {
                        HymnNumber = 85,
                        HymnTitle = "How Firm a Foundation"
                    },

                    new Hymn
                    {
                        HymnNumber = 86,
                        HymnTitle = "How Great Thou Art"
                    },

                    new Hymn
                    {
                        HymnNumber = 87,
                        HymnTitle = "God Is Love"
                    },

                    new Hymn
                    {
                        HymnNumber = 88,
                        HymnTitle = "Great God, Attend While Zion Sings"
                    },

                    new Hymn
                    {
                        HymnNumber = 89,
                        HymnTitle = "The Lord Is My Light"
                    },

                    new Hymn
                    {
                        HymnNumber = 90,
                        HymnTitle = "From All That Dwell below the Skies"
                    },

                    new Hymn
                    {
                        HymnNumber = 91,
                        HymnTitle = "Father, Thy Children to Thee Now Raise"
                    },

                    new Hymn
                    {
                        HymnNumber = 92,
                        HymnTitle = "For the Beauty of the Earth"
                    },

                    new Hymn
                    {
                        HymnNumber = 93,
                        HymnTitle = "Prayer of Thanksgiving"
                    },

                    new Hymn
                    {
                        HymnNumber = 94,
                        HymnTitle = "Come, Ye Thankful People"
                    },

                    new Hymn
                    {
                        HymnNumber = 95,
                        HymnTitle = "Now Thank We All Our God"
                    },

                    new Hymn
                    {
                        HymnNumber = 96,
                        HymnTitle = "Dearest Children, God Is Near You"
                    },

                    new Hymn
                    {
                        HymnNumber = 97,
                        HymnTitle = "Lead, Kindly Light"
                    },

                    new Hymn
                    {
                        HymnNumber = 98,
                        HymnTitle = "I Need Thee Every Hour"
                    },

                    new Hymn
                    {
                        HymnNumber = 99,
                        HymnTitle = "Nearer, Dear Savior, to Thee"
                    },

                    new Hymn
                    {
                        HymnNumber = 100,
                        HymnTitle = "Nearer, My God, to Thee"
                    },

                    new Hymn
                    {
                        HymnNumber = 101,
                        HymnTitle = "Guide Me to Thee"
                    },

                    new Hymn
                    {
                        HymnNumber = 102,
                        HymnTitle = "Jesus, Lover of My Soul"
                    },

                    new Hymn
                    {
                        HymnNumber = 103,
                        HymnTitle = "Precious Savior, Dear Redeemer"
                    },

                    new Hymn
                    {
                        HymnNumber = 104,
                        HymnTitle = "Jesus, Savior, Pilot Me"
                    },

                    new Hymn
                    {
                        HymnNumber = 105,
                        HymnTitle = "Master, the Tempest Is Raging"
                    },

                    new Hymn
                    {
                        HymnNumber = 106,
                        HymnTitle = "God Speed the Right"
                    },

                    new Hymn
                    {
                        HymnNumber = 107,
                        HymnTitle = "Lord, Accept Our True Devotion"
                    },

                    new Hymn
                    {
                        HymnNumber = 108,
                        HymnTitle = "The Lord Is My Shepherd"
                    },

                    new Hymn
                    {
                        HymnNumber = 109,
                        HymnTitle = "The Lord My Pasture Will Prepare"
                    },

                    new Hymn
                    {
                        HymnNumber = 110,
                        HymnTitle = "Cast Thy Burden upon the Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 111,
                        HymnTitle = "Rock of Ages"
                    },

                    new Hymn
                    {
                        HymnNumber = 112,
                        HymnTitle = "Savior, Redeemer of My Soul"
                    },

                    new Hymn
                    {
                        HymnNumber = 113,
                        HymnTitle = "Our Savior's Love"
                    },

                    new Hymn
                    {
                        HymnNumber = 114,
                        HymnTitle = "Come unto Him"
                    },

                    new Hymn
                    {
                        HymnNumber = 115,
                        HymnTitle = "Come, Ye Disconsolate"
                    },

                    new Hymn
                    {
                        HymnNumber = 116,
                        HymnTitle = "Come, Follow Me"
                    },

                    new Hymn
                    {
                        HymnNumber = 117,
                        HymnTitle = "Come unto Jesus"
                    },

                    new Hymn
                    {
                        HymnNumber = 118,
                        HymnTitle = "Ye Simple Souls Who Stray"
                    },

                    new Hymn
                    {
                        HymnNumber = 119,
                        HymnTitle = "Come, We That Love the Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 120,
                        HymnTitle = "Lean on My Ample Arm"
                    },

                    new Hymn
                    {
                        HymnNumber = 121,
                        HymnTitle = "I'm a Pilgrim, I'm a Stranger"
                    },

                    new Hymn
                    {
                        HymnNumber = 122,
                        HymnTitle = "Though Deepening Trials"
                    },

                    new Hymn
                    {
                        HymnNumber = 123,
                        HymnTitle = "Oh, May My Soul Commune with Thee"
                    },

                    new Hymn
                    {
                        HymnNumber = 124,
                        HymnTitle = "Be Still, My Soul"
                    },

                    new Hymn
                    {
                        HymnNumber = 125,
                        HymnTitle = "How Gentle God's Commands"
                    },

                    new Hymn
                    {
                        HymnNumber = 126,
                        HymnTitle = "How Long, O Lord Most Holy and True"
                    },

                    new Hymn
                    {
                        HymnNumber = 127,
                        HymnTitle = "Does the Journey Seem Long?"
                    },

                    new Hymn
                    {
                        HymnNumber = 128,
                        HymnTitle = "When Faith Endures"
                    },

                    new Hymn
                    {
                        HymnNumber = 129,
                        HymnTitle = "Where Can I turn for Peace"
                    },

                    new Hymn
                    {
                        HymnNumber = 130,
                        HymnTitle = "Be Thou Humble"
                    },

                    new Hymn
                    {
                        HymnNumber = 131,
                        HymnTitle = "More Holiness Give Me"
                    },

                    new Hymn
                    {
                        HymnNumber = 132,
                        HymnTitle = "God Is in His Holy Temple"
                    },

                    new Hymn
                    {
                        HymnNumber = 133,
                        HymnTitle = "Father in Heaven"
                    },

                    new Hymn
                    {
                        HymnNumber = 134,
                        HymnTitle = "I Believe in Christ"
                    },

                    new Hymn
                    {
                        HymnNumber = 135,
                        HymnTitle = "My Redeemer Lives"
                    },

                    new Hymn
                    {
                        HymnNumber = 136,
                        HymnTitle = "I Know That My Redeemer Lives"
                    },

                    new Hymn
                    {
                        HymnNumber = 137,
                        HymnTitle = "Testimony"
                    },

                    new Hymn
                    {
                        HymnNumber = 138,
                        HymnTitle = "Bless Our Fast, We Pray"
                    },

                    new Hymn
                    {
                        HymnNumber = 139,
                        HymnTitle = "In Fasting We Approach Thee"
                    },

                    new Hymn
                    {
                        HymnNumber = 140,
                        HymnTitle = "Did You Think to Pray"
                    },

                    new Hymn
                    {
                        HymnNumber = 141,
                        HymnTitle = "Jesus, the Very Thought of Thee"
                    },

                    new Hymn
                    {
                        HymnNumber = 142,
                        HymnTitle = "Sweet Hour of Prayer"
                    },

                    new Hymn
                    {
                        HymnNumber = 143,
                        HymnTitle = "Let the Holy Spirit Guide"
                    },

                    new Hymn
                    {
                        HymnNumber = 144,
                        HymnTitle = "Secret Prayer"
                    },

                    new Hymn
                    {
                        HymnNumber = 145,
                        HymnTitle = "Prayer Is the Soul's Sincere Desire"
                    },

                    new Hymn
                    {
                        HymnNumber = 146,
                        HymnTitle = "Gently Raise the Sacred Strain"
                    },

                    new Hymn
                    {
                        HymnNumber = 147,
                        HymnTitle = "Sweet Is the Word"
                    },

                    new Hymn
                    {
                        HymnNumber = 148,
                        HymnTitle = "Sabbath Day"
                    },

                    new Hymn
                    {
                        HymnNumber = 149,
                        HymnTitle = "As the Dew from Heaven Distilling"
                    },

                    new Hymn
                    {
                        HymnNumber = 150,
                        HymnTitle = "O Thou Kind and Gracious Father"
                    },

                    new Hymn
                    {
                        HymnNumber = 151,
                        HymnTitle = "We Meet, Dear Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 152,
                        HymnTitle = "God Be with you Till We Meet Again"
                    },

                    new Hymn
                    {
                        HymnNumber = 153,
                        HymnTitle = "Lord, We Ask Thee Ere We Part"
                    },

                    new Hymn
                    {
                        HymnNumber = 154,
                        HymnTitle = "Father, This Hour Has Been One of Joy"
                    },

                    new Hymn
                    {
                        HymnNumber = 155,
                        HymnTitle = "We Have Partaken of Thy Love"
                    },

                    new Hymn
                    {
                        HymnNumber = 156,
                        HymnTitle = "Sing We Now at Parting"
                    },

                    new Hymn
                    {
                        HymnNumber = 157,
                        HymnTitle = "Thy Spirit, Lord, Has Stirred Our Souls"
                    },

                    new Hymn
                    {
                        HymnNumber = 158,
                        HymnTitle = "Before Thee, Lord, I Bow My Head"
                    },

                    new Hymn
                    {
                        HymnNumber = 159,
                        HymnTitle = "Now the Day Is Over"
                    },

                    new Hymn
                    {
                        HymnNumber = 160,
                        HymnTitle = "Softly Now the Light of Day"
                    },

                    new Hymn
                    {
                        HymnNumber = 161,
                        HymnTitle = "The Lord Be with Us"
                    },

                    new Hymn
                    {
                        HymnNumber = 162,
                        HymnTitle = "Lord, We Come before Thee Now"
                    },

                    new Hymn
                    {
                        HymnNumber = 163,
                        HymnTitle = "Lord, Dismiss Us with Thy Blessing"
                    },

                    new Hymn
                    {
                        HymnNumber = 164,
                        HymnTitle = "Great God, to Thee My Evening Song"
                    },

                    new Hymn
                    {
                        HymnNumber = 165,
                        HymnTitle = "Abide with Me; 'Tis Eventide"
                    },

                    new Hymn
                    {
                        HymnNumber = 166,
                        HymnTitle = "Abide with Me!"
                    },

                    new Hymn
                    {
                        HymnNumber = 167,
                        HymnTitle = "Come, Let Us Sing an Evening Hymn"
                    },

                    new Hymn
                    {
                        HymnNumber = 168,
                        HymnTitle = "As the Shadows Fall"
                    },

                    new Hymn
                    {
                        HymnNumber = 169,
                        HymnTitle = "As Now We Take the Sacrament"
                    },

                    new Hymn
                    {
                        HymnNumber = 170,
                        HymnTitle = "God, Our Father, Hear Us Pray"
                    },

                    new Hymn
                    {
                        HymnNumber = 171,
                        HymnTitle = "With Humble Heart"
                    },

                    new Hymn
                    {
                        HymnNumber = 172,
                        HymnTitle = "In Humility, Our Savior"
                    },

                    new Hymn
                    {
                        HymnNumber = 173,
                        HymnTitle = "While of These Emblems We Partake"
                    },

                    new Hymn
                    {
                        HymnNumber = 174,
                        HymnTitle = "While of These Emblems We Partake"
                    },

                    new Hymn
                    {
                        HymnNumber = 175,
                        HymnTitle = "O God, the Eternal Father"
                    },

                    new Hymn
                    {
                        HymnNumber = 176,
                        HymnTitle = "'Tis Sweet to Sing the Matchless Love"
                    },

                    new Hymn
                    {
                        HymnNumber = 177,
                        HymnTitle = "'Tis Sweet to Sing the Matchless Love"
                    },

                    new Hymn
                    {
                        HymnNumber = 178,
                        HymnTitle = "O Lord of Hosts"
                    },

                    new Hymn
                    {
                        HymnNumber = 179,
                        HymnTitle = "Again, our Dear Redeeming Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 180,
                        HymnTitle = "Father in Heaven, We Do Believe"
                    },

                    new Hymn
                    {
                        HymnNumber = 181,
                        HymnTitle = "Jesus of Nazareth, Savior and King"
                    },

                    new Hymn
                    {
                        HymnNumber = 182,
                        HymnTitle = "We'll Sing All Hail to Jesus' Name"
                    },

                    new Hymn
                    {
                        HymnNumber = 183,
                        HymnTitle = "In Remembrance of Thy Suffering"
                    },

                    new Hymn
                    {
                        HymnNumber = 184,
                        HymnTitle = "Upon the Cross of Calvary"
                    },

                    new Hymn
                    {
                        HymnNumber = 185,
                        HymnTitle = "Reverently and Meekly Now"
                    },

                    new Hymn
                    {
                        HymnNumber = 186,
                        HymnTitle = "Again We Meet around the Board"
                    },

                    new Hymn
                    {
                        HymnNumber = 187,
                        HymnTitle = "God Love Us, So He Sent His Son"
                    },

                    new Hymn
                    {
                        HymnNumber = 188,
                        HymnTitle = "Thy Will, O Lord, Be Done"
                    },

                    new Hymn
                    {
                        HymnNumber = 189,
                        HymnTitle = "O Thou, Before the World Began"
                    },

                    new Hymn
                    {
                        HymnNumber = 190,
                        HymnTitle = "In Memory of the Crucified"
                    },

                    new Hymn
                    {
                        HymnNumber = 191,
                        HymnTitle = "Behold the Great Redeemer Die"
                    },

                    new Hymn
                    {
                        HymnNumber = 192,
                        HymnTitle = "He Died! The Great Redeemer Died"
                    },

                    new Hymn
                    {
                        HymnNumber = 193,
                        HymnTitle = "I Stand All Amazed"
                    },

                    new Hymn
                    {
                        HymnNumber = 194,
                        HymnTitle = "There Is a Green Hill Far Away"
                    },

                    new Hymn
                    {
                        HymnNumber = 195,
                        HymnTitle = "How Great the Wisdom and the Love"
                    },

                    new Hymn
                    {
                        HymnNumber = 196,
                        HymnTitle = "Jesus, Once of Humble Birth"
                    },

                    new Hymn
                    {
                        HymnNumber = 197,
                        HymnTitle = "O Savior, Thou Who Wearest a Crown"
                    },

                    new Hymn
                    {
                        HymnNumber = 198,
                        HymnTitle = "That Easter Morn"
                    },

                    new Hymn
                    {
                        HymnNumber = 199,
                        HymnTitle = "He Is Risen!"
                    },

                    new Hymn
                    {
                        HymnNumber = 200,
                        HymnTitle = "Christ the Lord Is Risen Today"
                    },

                    new Hymn
                    {
                        HymnNumber = 201,
                        HymnTitle = "Joy to the World"
                    },

                    new Hymn
                    {
                        HymnNumber = 202,
                        HymnTitle = "Oh, Come, All Ye Faithful"
                    },

                    new Hymn
                    {
                        HymnNumber = 203,
                        HymnTitle = "Angels We Have Heard on High"
                    },

                    new Hymn
                    {
                        HymnNumber = 204,
                        HymnTitle = "Silent Night"
                    },

                    new Hymn
                    {
                        HymnNumber = 205,
                        HymnTitle = "Once in Royal David's City"
                    },

                    new Hymn
                    {
                        HymnNumber = 206,
                        HymnTitle = "Away in a Manger"
                    },

                    new Hymn
                    {
                        HymnNumber = 207,
                        HymnTitle = "It Came upon the Midnight Clear"
                    },

                    new Hymn
                    {
                        HymnNumber = 208,
                        HymnTitle = "O Little Town of Bethlehem"
                    },

                    new Hymn
                    {
                        HymnNumber = 209,
                        HymnTitle = "Hark! The Herald Angels Sing"
                    },

                    new Hymn
                    {
                        HymnNumber = 210,
                        HymnTitle = "With Wondering Awe"
                    },

                    new Hymn
                    {
                        HymnNumber = 211,
                        HymnTitle = "While Shepherds Watched Their Flocks"
                    },

                    new Hymn
                    {
                        HymnNumber = 212,
                        HymnTitle = "Far, Far Away on Judea’s Plains"
                    },

                    new Hymn
                    {
                        HymnNumber = 213,
                        HymnTitle = "The First Noel"
                    },

                    new Hymn
                    {
                        HymnNumber = 214,
                        HymnTitle = "I Heard the Bells on Christmas Day"
                    },

                    new Hymn
                    {
                        HymnNumber = 215,
                        HymnTitle = "Ring Out, Wild Bells"
                    },

                    new Hymn
                    {
                        HymnNumber = 216,
                        HymnTitle = "We Are Sowing"
                    },

                    new Hymn
                    {
                        HymnNumber = 217,
                        HymnTitle = "Come, Let Us Anew"
                    },

                    new Hymn
                    {
                        HymnNumber = 218,
                        HymnTitle = "We Give Thee But Thine Own"
                    },

                    new Hymn
                    {
                        HymnNumber = 219,
                        HymnTitle = "Because I Have Been Given Much"
                    },

                    new Hymn
                    {
                        HymnNumber = 220,
                        HymnTitle = "Lord, I Would Follow Thee"
                    },

                    new Hymn
                    {
                        HymnNumber = 221,
                        HymnTitle = "Dear to the Heart of the Shepherd"
                    },

                    new Hymn
                    {
                        HymnNumber = 222,
                        HymnTitle = "Hear Thou Our Hymn, O Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 223,
                        HymnTitle = "Have I Done Any Good?"
                    },

                    new Hymn
                    {
                        HymnNumber = 224,
                        HymnTitle = "I Have Work Enough to Do"
                    },

                    new Hymn
                    {
                        HymnNumber = 225,
                        HymnTitle = "We Are Marching On to Glory"
                    },

                    new Hymn
                    {
                        HymnNumber = 226,
                        HymnTitle = "Improve the Shining Moments"
                    },

                    new Hymn
                    {
                        HymnNumber = 227,
                        HymnTitle = "There Is Sunshine in My Soul Today"
                    },

                    new Hymn
                    {
                        HymnNumber = 228,
                        HymnTitle = "You Can Make the Pathway Bright"
                    },

                    new Hymn
                    {
                        HymnNumber = 229,
                        HymnTitle = "Today, While the Sun Shines"
                    },

                    new Hymn
                    {
                        HymnNumber = 230,
                        HymnTitle = "Scatter Sunshine"
                    },

                    new Hymn
                    {
                        HymnNumber = 231,
                        HymnTitle = "Father, Cheer Our Souls Tonight"
                    },

                    new Hymn
                    {
                        HymnNumber = 232,
                        HymnTitle = "Let Us Oft Speak Kind Words"
                    },

                    new Hymn
                    {
                        HymnNumber = 233,
                        HymnTitle = "Nay, Speak No Ill"
                    },

                    new Hymn
                    {
                        HymnNumber = 234,
                        HymnTitle = "Jesus, Mighty King in Zion"
                    },

                    new Hymn
                    {
                        HymnNumber = 235,
                        HymnTitle = "Should You Feel Inclined to Censure"
                    },

                    new Hymn
                    {
                        HymnNumber = 236,
                        HymnTitle = "Lord, Accept into Thy Kingdom"
                    },

                    new Hymn
                    {
                        HymnNumber = 237,
                        HymnTitle = "Do What Is Right"
                    },

                    new Hymn
                    {
                        HymnNumber = 238,
                        HymnTitle = "Behold Thy Sons and Daughters, Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 239,
                        HymnTitle = "Choose the Right"
                    },

                    new Hymn
                    {
                        HymnNumber = 240,
                        HymnTitle = "Know This, That Every Soul Is Free"
                    },

                    new Hymn
                    {
                        HymnNumber = 241,
                        HymnTitle = "Count Your Blessings"
                    },

                    new Hymn
                    {
                        HymnNumber = 242,
                        HymnTitle = "Praise God, from Whom All Blessings Flow"
                    },

                    new Hymn
                    {
                        HymnNumber = 243,
                        HymnTitle = "Let Us All Press On"
                    },

                    new Hymn
                    {
                        HymnNumber = 244,
                        HymnTitle = "Come Along, Come Along"
                    },

                    new Hymn
                    {
                        HymnNumber = 245,
                        HymnTitle = "This House We Dedicate to Thee"
                    },

                    new Hymn
                    {
                        HymnNumber = 246,
                        HymnTitle = "Onward, Christian Soldiers"
                    },

                    new Hymn
                    {
                        HymnNumber = 247,
                        HymnTitle = "We Love Thy House, O God"
                    },

                    new Hymn
                    {
                        HymnNumber = 248,
                        HymnTitle = "Up, Awake, Ye Defenders of Zion"
                    },

                    new Hymn
                    {
                        HymnNumber = 249,
                        HymnTitle = "Called to Serve"
                    },

                    new Hymn
                    {
                        HymnNumber = 250,
                        HymnTitle = "We Are All Enlisted"
                    },

                    new Hymn
                    {
                        HymnNumber = 251,
                        HymnTitle = "Behold! A Royal Army"
                    },

                    new Hymn
                    {
                        HymnNumber = 252,
                        HymnTitle = "Put Your Shoulder to the Wheel"
                    },

                    new Hymn
                    {
                        HymnNumber = 253,
                        HymnTitle = "Like Ten Thousand Legions Marching"
                    },

                    new Hymn
                    {
                        HymnNumber = 254,
                        HymnTitle = "True to the Faith"
                    },

                    new Hymn
                    {
                        HymnNumber = 255,
                        HymnTitle = "Carry On"
                    },

                    new Hymn
                    {
                        HymnNumber = 256,
                        HymnTitle = "As Zion’s Youth in Latter Days"
                    },

                    new Hymn
                    {
                        HymnNumber = 257,
                        HymnTitle = "Rejoice! A Glorious Sound Is Heard"
                    },

                    new Hymn
                    {
                        HymnNumber = 258,
                        HymnTitle = "O Thou Rock of Our Salvation"
                    },

                    new Hymn
                    {
                        HymnNumber = 259,
                        HymnTitle = "Hope of Israel"
                    },

                    new Hymn
                    {
                        HymnNumber = 260,
                        HymnTitle = "Who’s on the Lord’s Side?"
                    },

                    new Hymn
                    {
                        HymnNumber = 261,
                        HymnTitle = "Thy Servants Are Prepared"
                    },

                    new Hymn
                    {
                        HymnNumber = 262,
                        HymnTitle = "Go, Ye Messengers of Glory"
                    },

                    new Hymn
                    {
                        HymnNumber = 263,
                        HymnTitle = "Go Forth with Faith"
                    },

                    new Hymn
                    {
                        HymnNumber = 264,
                        HymnTitle = "Hark, All Ye Nations!"
                    },

                    new Hymn
                    {
                        HymnNumber = 265,
                        HymnTitle = "Arise, O God, and Shine"
                    },

                    new Hymn
                    {
                        HymnNumber = 266,
                        HymnTitle = "The Time Is Far Spent"
                    },

                    new Hymn
                    {
                        HymnNumber = 267,
                        HymnTitle = "How Wondrous and Great"
                    },

                    new Hymn
                    {
                        HymnNumber = 268,
                        HymnTitle = "Come, All Whose Souls Are Lighted"
                    },

                    new Hymn
                    {
                        HymnNumber = 269,
                        HymnTitle = "Jehovah, Lord of Heaven and Earth"
                    },

                    new Hymn
                    {
                        HymnNumber = 270,
                        HymnTitle = "I’ll Go Where You Want Me to Go"
                    },

                    new Hymn
                    {
                        HymnNumber = 271,
                        HymnTitle = "Oh, Holy Words of Truth and Love"
                    },

                    new Hymn
                    {
                        HymnNumber = 272,
                        HymnTitle = "Oh Say, What Is Truth?"
                    },

                    new Hymn
                    {
                        HymnNumber = 273,
                        HymnTitle = "Truth Reflects upon Our Senses"
                    },

                    new Hymn
                    {
                        HymnNumber = 274,
                        HymnTitle = "The Iron Rod"
                    },

                    new Hymn
                    {
                        HymnNumber = 275,
                        HymnTitle = "Men Are That They Might Have Joy"
                    },

                    new Hymn
                    {
                        HymnNumber = 276,
                        HymnTitle = "Come Away to the Sunday School"
                    },

                    new Hymn
                    {
                        HymnNumber = 277,
                        HymnTitle = "As I Search the Holy Scriptures"
                    },

                    new Hymn
                    {
                        HymnNumber = 278,
                        HymnTitle = "Thanks for the Sabbath School"
                    },

                    new Hymn
                    {
                        HymnNumber = 279,
                        HymnTitle = "Thy Holy Word"
                    },

                    new Hymn
                    {
                        HymnNumber = 280,
                        HymnTitle = "Welcome, Welcome, Sabbath Morning"
                    },

                    new Hymn
                    {
                        HymnNumber = 281,
                        HymnTitle = "Help Me Teach with Inspiration"
                    },

                    new Hymn
                    {
                        HymnNumber = 282,
                        HymnTitle = "We Meet Again in Sabbath School"
                    },

                    new Hymn
                    {
                        HymnNumber = 283,
                        HymnTitle = "The Glorious Gospel Light Has Shone"
                    },

                    new Hymn
                    {
                        HymnNumber = 284,
                        HymnTitle = "If You Could Hie to Kolob"
                    },

                    new Hymn
                    {
                        HymnNumber = 285,
                        HymnTitle = "God Moves in a Mysterious Way"
                    },

                    new Hymn
                    {
                        HymnNumber = 286,
                        HymnTitle = "Oh, What Songs of the Heart"
                    },

                    new Hymn
                    {
                        HymnNumber = 287,
                        HymnTitle = "Rise, Ye Saints, and Temples Enter"
                    },

                    new Hymn
                    {
                        HymnNumber = 288,
                        HymnTitle = "How Beautiful Thy Temples, Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 289,
                        HymnTitle = "Holy Temples on Mount Zion"
                    },

                    new Hymn
                    {
                        HymnNumber = 290,
                        HymnTitle = "Rejoice, Ye Saints of Latter Days"
                    },

                    new Hymn
                    {
                        HymnNumber = 291,
                        HymnTitle = "Turn Your Hearts"
                    },

                    new Hymn
                    {
                        HymnNumber = 292,
                        HymnTitle = "O My Father"
                    },

                    new Hymn
                    {
                        HymnNumber = 293,
                        HymnTitle = "Each Life That Touches Ours for Good"
                    },

                    new Hymn
                    {
                        HymnNumber = 294,
                        HymnTitle = "Love at Home"
                    },

                    new Hymn
                    {
                        HymnNumber = 295,
                        HymnTitle = "O Love That Glorifies the Son"
                    },

                    new Hymn
                    {
                        HymnNumber = 296,
                        HymnTitle = "Our Father, by Whose Name"
                    },

                    new Hymn
                    {
                        HymnNumber = 297,
                        HymnTitle = "From Homes of Saints Glad Songs Arise"
                    },

                    new Hymn
                    {
                        HymnNumber = 298,
                        HymnTitle = "Home Can Be a Heaven on Earth"
                    },

                    new Hymn
                    {
                        HymnNumber = 299,
                        HymnTitle = "Children of Our Heavenly Father"
                    },

                    new Hymn
                    {
                        HymnNumber = 300,
                        HymnTitle = "Families Can Be Together Forever"
                    },

                    new Hymn
                    {
                        HymnNumber = 301,
                        HymnTitle = "I Am a Child of God"
                    },
                    new Hymn
                    {
                        HymnNumber = 302,
                        HymnTitle = "I Know My Father Lives"
                    },

                    new Hymn
                    {
                        HymnNumber = 303,
                        HymnTitle = "Keep the Commandments"
                    },

                    new Hymn
                    {
                        HymnNumber = 304,
                        HymnTitle = "Teach Me to Walk in the Light"
                    },
                    new Hymn
                    {
                        HymnNumber = 305,
                        HymnTitle = "The Light Divine"
                    },

                    new Hymn
                    {
                        HymnNumber = 306,
                        HymnTitle = "God’s Daily Care"
                    },

                    new Hymn
                    {
                        HymnNumber = 307,
                        HymnTitle = "In Our Lovely Deseret"
                    },

                    new Hymn
                    {
                        HymnNumber = 308,
                        HymnTitle = "Love One Another"
                    },

                    new Hymn
                    {
                        HymnNumber = 309,
                        HymnTitle = "As Sisters in Zion"
                    },
                    new Hymn
                    {
                        HymnNumber = 310,
                        HymnTitle = "A Key Was Turned in Latter Days"
                    },

                    new Hymn
                    {
                        HymnNumber = 311,
                        HymnTitle = "We Meet Again as Sisters"
                    },

                    new Hymn
                    {
                        HymnNumber = 312,
                        HymnTitle = "We Ever Pray for Thee"
                    },

                    new Hymn
                    {
                        HymnNumber = 313,
                        HymnTitle = "God Is Love"
                    },

                    new Hymn
                    {
                        HymnNumber = 314,
                        HymnTitle = "How Gentle God’s Commands"
                    },
                    new Hymn
                    {
                        HymnNumber = 315,
                        HymnTitle = "Jesus, the Very Thought of Thee"
                    },
                    new Hymn
                    {
                        HymnNumber = 316,
                        HymnTitle = "The Lord Is My Shepherd"
                    },

                    new Hymn
                    {
                        HymnNumber = 317,
                        HymnTitle = "Sweet Is the Work"
                    },

                    new Hymn
                    {
                        HymnNumber = 318,
                        HymnTitle = "Love at Home"
                    },

                    new Hymn
                    {
                        HymnNumber = 319,
                        HymnTitle = "Ye Elders of Israel"
                    },

                    new Hymn
                    {
                        HymnNumber = 320,
                        HymnTitle = "The Priesthood of Our Lord"
                    },

                    new Hymn
                    {
                        HymnNumber = 321,
                        HymnTitle = "Ye Who Are Called to Labor"
                    },

                    new Hymn
                    {
                        HymnNumber = 322,
                        HymnTitle = "Come, All Ye Sons of God"
                    },
                    new Hymn
                    {
                        HymnNumber = 323,
                        HymnTitle = "Rise Up, O Men of God"
                    },

                    new Hymn
                    {
                        HymnNumber = 324,
                        HymnTitle = "Rise Up, O Men of God"
                    },

                    new Hymn
                    {
                        HymnNumber = 325,
                        HymnTitle = "See the Mighty Priesthood Gathered"
                    },

                    new Hymn
                    {
                        HymnNumber = 326,
                        HymnTitle = "Come, Come, Ye Saints"
                    },

                    new Hymn
                    {
                        HymnNumber = 327,
                        HymnTitle = "Go, Ye Messengers of Heaven"
                    },

                    new Hymn
                    {
                        HymnNumber = 328,
                        HymnTitle = "An Angel from on High"
                    },

                    new Hymn
                    {
                        HymnNumber = 329,
                        HymnTitle = "Thy Servants Are Prepared"
                    },

                    new Hymn
                    {
                        HymnNumber = 330,
                        HymnTitle = "See, the Mighty Angel Flying"
                    },
                    new Hymn
                    {
                        HymnNumber = 331,
                        HymnTitle = "Oh Say, What Is Truth?"
                    },
                    new Hymn
                    {
                        HymnNumber = 332,
                        HymnTitle = "Come, O Thou King of Kings"
                    },

                    new Hymn
                    {
                        HymnNumber = 333,
                        HymnTitle = "High on the Mountain Top"
                    },

                    new Hymn
                    {
                        HymnNumber = 334,
                        HymnTitle = "I Need Thee Every Hour"
                    },

                    new Hymn
                    {
                        HymnNumber = 335,
                        HymnTitle = "Brightly Beams Our Father’s Mercy"
                    },

                    new Hymn
                    {
                        HymnNumber = 336,
                        HymnTitle = "School Thy Feelings"
                    },

                    new Hymn
                    {
                        HymnNumber = 337,
                        HymnTitle = "O home Beloved"
                    },
                    new Hymn
                    {
                        HymnNumber = 338,
                        HymnTitle = "America the Beautiful"
                    },
                    new Hymn
                    {
                        HymnNumber = 339,
                        HymnTitle = "My Country, Tis of Thee"
                    },
                    new Hymn
                    {
                        HymnNumber = 340,
                        HymnTitle = "The Star-Spangled Banner"
                    },

                    new Hymn
                    {
                        HymnNumber = 341,
                        HymnTitle = "God Save the King"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
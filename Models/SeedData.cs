using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MusicianDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<MusicianDbContext>>()))
            {
                // Look for any musicians.
                if (context.Musicians.Any())
                {
                    return; // DB has been seeded
                }
                
                // creating each isntrument to then add to a musician. 
                var guitar = GetOrCreateInstrument(context, "Guitar");
                var piano = GetOrCreateInstrument(context, "Piano");
                var drums = GetOrCreateInstrument(context, "Drums");
                var trumpet = GetOrCreateInstrument(context, "Trumpet");
                var bass = GetOrCreateInstrument(context, "Bass");
                var doublebass = GetOrCreateInstrument(context, "Double Bass");
                var cello = GetOrCreateInstrument(context, "Cello");
                var violin = GetOrCreateInstrument(context, "Violin");
                var clarinet = GetOrCreateInstrument(context, "Clarinet");

                // You were right, I bite of way more than I could chew and I am glad
                // We took some things out. This whole project took me a really long time
                // but I learned a lot.

                // Seeding data with Musicians, Instruments, and Discographies. 
                context.Musicians.AddRange(
                    new Musician
                    {
                        MusicianName = "Eric Clapton",
                        Website = "https://ericclapton.com/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = guitar}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Eric Clapton", ReleaseDate = 1970},
                            new Discography {RecordName = "461 Ocean Boulevard", ReleaseDate = 1974},
                            new Discography {RecordName = "There's One in Every Crowd", ReleaseDate = 1975},
                            new Discography {RecordName = "No Reason to Cry", ReleaseDate = 1976},
                            new Discography {RecordName = "Slowhand", ReleaseDate = 1977},
                            new Discography {RecordName = "Blackless", ReleaseDate = 1978},
                            new Discography {RecordName = "Another Ticket", ReleaseDate = 1981},
                            new Discography {RecordName = "Money and Cigarettes", ReleaseDate = 1983},
                            new Discography {RecordName = "Behind the Sun", ReleaseDate = 1985},
                            new Discography {RecordName = "August", ReleaseDate = 1986},
                            new Discography {RecordName = "Journeyman", ReleaseDate = 1989},
                            new Discography {RecordName = "From the Cradle", ReleaseDate = 1994},
                            new Discography {RecordName = "Pilgrim", ReleaseDate = 1998},
                            new Discography {RecordName = "Reptile", ReleaseDate = 2001},
                            new Discography {RecordName = "Me and Mr. Johnson", ReleaseDate = 2004},
                            new Discography {RecordName = "Sessions for Robert J", ReleaseDate = 2004},
                            new Discography {RecordName = "Back Home", ReleaseDate = 2005},
                            new Discography {RecordName = "Clapton", ReleaseDate = 2010},
                            new Discography {RecordName = "Old Sock", ReleaseDate = 2013},
                            new Discography {RecordName = "I Still Do", ReleaseDate = 2016},
                            new Discography {RecordName = "Happy Xmas", ReleaseDate = 2018}
                        }
                    },                    
                    new Musician
                    {
                        MusicianName = "Elton John",
                        Website = "https://www.eltonjohn.com/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = piano}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Empty Sky", ReleaseDate = 1969},
                            new Discography {RecordName = "Elton John", ReleaseDate = 1970},
                            new Discography {RecordName = "Tumbleweed Connection", ReleaseDate = 1970},
                            new Discography {RecordName = "Madman Across the Water", ReleaseDate = 1971},
                            new Discography {RecordName = "Honky Château", ReleaseDate = 1972},
                            new Discography {RecordName = "Don't Shoot Me I'm Only the Piano Player", ReleaseDate = 1973},
                            new Discography {RecordName = "Goodbye Yellow Brick Road", ReleaseDate = 1973},
                            new Discography {RecordName = "Caribou", ReleaseDate = 1974},
                            new Discography {RecordName = "Captain Fantastic and the Brown Dirt Cowboy", ReleaseDate = 1975},
                            new Discography {RecordName = "Rock of the Westies", ReleaseDate = 1975},
                            new Discography {RecordName = "Blue Moves", ReleaseDate = 1976},
                            new Discography {RecordName = "A Single Man", ReleaseDate = 1978},
                            new Discography {RecordName = "Victim of Love", ReleaseDate = 1979},
                            new Discography {RecordName = "21 at 33", ReleaseDate = 1980},
                            new Discography {RecordName = "The Fox", ReleaseDate = 1981},
                            new Discography {RecordName = "Jump Up!", ReleaseDate = 1982},
                            new Discography {RecordName = "Too Low for Zero", ReleaseDate = 1983},
                            new Discography {RecordName = "Breaking Hearts", ReleaseDate = 1984},
                            new Discography {RecordName = "Ice on Fire", ReleaseDate = 1985},
                            new Discography {RecordName = "Leather Jackets", ReleaseDate = 1986},
                            new Discography {RecordName = "Reg Strikes Back", ReleaseDate = 1988},
                            new Discography {RecordName = "Sleeping with the Past", ReleaseDate = 1989},
                            new Discography {RecordName = "The One", ReleaseDate = 1992},
                            new Discography {RecordName = "Made in England", ReleaseDate = 1995},
                            new Discography {RecordName = "The Big Picture", ReleaseDate = 1997},
                            new Discography {RecordName = "Songs from the West Coast", ReleaseDate = 2001},
                            new Discography {RecordName = "Peachtree Road", ReleaseDate = 2004},
                            new Discography {RecordName = "The Captain & the Kid", ReleaseDate = 2006},
                            new Discography {RecordName = "The Diving Board", ReleaseDate = 2013},
                            new Discography {RecordName = "Wonderful Crazy Night", ReleaseDate = 2016},
                            new Discography {RecordName = "Regimental Sgt. Zippo", ReleaseDate = 2021}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Ringo Starr",
                        Website = "https://www.ringostarr.com/#/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = drums}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Sentimental Journey", ReleaseDate = 1970},
                            new Discography {RecordName = "Beaucoups of Blues", ReleaseDate = 1970},
                            new Discography {RecordName = "Ringo", ReleaseDate = 1973},
                            new Discography {RecordName = "Goodnight Vienna", ReleaseDate = 1974},
                            new Discography {RecordName = "Ringo's Rotogravure", ReleaseDate = 1976},
                            new Discography {RecordName = "Ringo the 4th", ReleaseDate = 1977},
                            new Discography {RecordName = "Bad Boy", ReleaseDate = 1978},
                            new Discography {RecordName = "Stop and Smell the Roses", ReleaseDate = 1981},
                            new Discography {RecordName = "Old Wave", ReleaseDate = 1983},
                            new Discography {RecordName = "Time Takes Time", ReleaseDate = 1992},
                            new Discography {RecordName = "Vertical Man", ReleaseDate = 1998},
                            new Discography {RecordName = "I Wanna Be Santa Claus", ReleaseDate = 1999},
                            new Discography {RecordName = "Ringo Rama", ReleaseDate = 2003},
                            new Discography {RecordName = "Choose Love", ReleaseDate = 2005},
                            new Discography {RecordName = "Liverpool 8", ReleaseDate = 2008},
                            new Discography {RecordName = "Y Not", ReleaseDate = 2010},
                            new Discography {RecordName = "Ringo 2012", ReleaseDate = 2012},
                            new Discography {RecordName = "Postcards from Paradise", ReleaseDate = 2015},
                            new Discography {RecordName = "Give More Love", ReleaseDate = 2017},
                            new Discography {RecordName = "What's My Name", ReleaseDate = 2019}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Willie Nelson",
                        Website = "https://willienelson.com/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = guitar}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "...And Then I Wrote", ReleaseDate = 1962},
                            new Discography {RecordName = "Here's Willie Nelson", ReleaseDate = 1963},
                            new Discography {RecordName = "Country Willie - His Own Songs", ReleaseDate = 1965},
                            new Discography {RecordName = "Country Favorites - Willie Nelson Style", ReleaseDate = 1966},
                            new Discography {RecordName = "Make Way for Willie Nelson", ReleaseDate = 1967},
                            new Discography {RecordName = "The Party's Over", ReleaseDate = 1967},
                            new Discography {RecordName = "Texas in My Soul", ReleaseDate = 1968},
                            new Discography {RecordName = "Good Times", ReleaseDate = 1968},
                            new Discography {RecordName = "My Own Peculiar Way", ReleaseDate = 1969},
                            new Discography {RecordName = "Both Sides Now", ReleaseDate = 1970},
                            new Discography {RecordName = "Laying My Burdens Down", ReleaseDate = 1970},
                            new Discography {RecordName = "Willie Nelson and Family", ReleaseDate = 1971},
                            new Discography {RecordName = "Yesterday's Wine", ReleaseDate = 1971},
                            new Discography {RecordName = "The Words Don't Fit the Picture", ReleaseDate = 1972},
                            new Discography {RecordName = "The Willie Way", ReleaseDate = 1972},
                            new Discography {RecordName = "Shotgun Willie", ReleaseDate = 1973},
                            new Discography {RecordName = "Phases and Stages", ReleaseDate = 1974},
                            new Discography {RecordName = "Red Headed Stranger", ReleaseDate = 1975},
                            new Discography {RecordName = "The Sound in Your Mind", ReleaseDate = 1976},
                            new Discography {RecordName = "The Troublemaker", ReleaseDate = 1976},
                            new Discography {RecordName = "To Lefty from Willie", ReleaseDate = 1977},
                            new Discography {RecordName = "Waylon & Willie", ReleaseDate = 1978},
                            new Discography {RecordName = "Stardust", ReleaseDate = 1978},
                            new Discography {RecordName = "One for the Road", ReleaseDate = 1979},
                            new Discography {RecordName = "Willie Nelson Sings Kristofferson", ReleaseDate = 1979},
                            new Discography {RecordName = "Pretty Paper", ReleaseDate = 1979},
                            new Discography {RecordName = "San Antonio Rose (with Ray Price)", ReleaseDate = 1980},
                            new Discography {RecordName = "Family Bible", ReleaseDate = 1980},
                            new Discography {RecordName = "Somewhere Over the Rainbow", ReleaseDate = 1981},
                            new Discography {RecordName = "Always on My Mind", ReleaseDate = 1982},
                            new Discography {RecordName = "Old Friends (with Roger Miller)", ReleaseDate = 1982},
                            new Discography {RecordName = "In the Jailhouse Now (with Webb Pierce)", ReleaseDate = 1982},
                            new Discography {RecordName = "WWII (with Waylon Jennings)", ReleaseDate = 1982},
                            new Discography {RecordName = "Pancho & Lefty (with Merle Haggard)", ReleaseDate = 1983},
                            new Discography {RecordName = "Tougher Than Leather", ReleaseDate = 1983},
                            new Discography {RecordName = "Take It to the Limit (with Waylon Jennings)", ReleaseDate = 1983},
                            new Discography {RecordName = "Without a Song", ReleaseDate = 1983},
                            new Discography {RecordName = "Angel Eyes", ReleaseDate = 1984},
                            new Discography {RecordName = "City of New Orleans", ReleaseDate = 1984},
                            new Discography {RecordName = "Music from Songwriter (with Kris Kristofferson)", ReleaseDate = 1984},
                            new Discography {RecordName = "Me and Paul", ReleaseDate = 1985},
                            new Discography {RecordName = "Funny How Time Slips Away (with Faron Young)", ReleaseDate = 1985},
                            new Discography {RecordName = "Brand on My Heart (with Hank Snow)", ReleaseDate = 1985},
                            new Discography {RecordName = "Partners", ReleaseDate = 1986},
                            new Discography {RecordName = "The Promiseland", ReleaseDate = 1986},
                            new Discography {RecordName = "Island in the Sea", ReleaseDate = 1987},
                            new Discography {RecordName = "Seashores of Old Mexico (with Merle Haggard)", ReleaseDate = 1987},
                            new Discography {RecordName = "What a Wonderful World", ReleaseDate = 1988},
                            new Discography {RecordName = "A Horse Called Music", ReleaseDate = 1989},
                            new Discography {RecordName = "Born for Trouble", ReleaseDate = 1990},
                            new Discography {RecordName = "The IRS Tapes: Who'll Buy My Memories?", ReleaseDate = 1991},
                            new Discography {RecordName = "Clean Shirt (with Waylon Jennings)", ReleaseDate = 1991},
                            new Discography {RecordName = "Across the Borderline", ReleaseDate = 1993},
                            new Discography {RecordName = "Moonlight Becomes You", ReleaseDate = 1994},
                            new Discography {RecordName = "Six Hours at Pedernales (with Curtis Potter)", ReleaseDate = 1994},
                            new Discography {RecordName = "Healing Hands of Time", ReleaseDate = 1994},
                            new Discography {RecordName = "Just One Love", ReleaseDate = 1995},
                            new Discography {RecordName = "Augusta (with Don Cherry)", ReleaseDate = 1995},
                            new Discography {RecordName = "Spirit", ReleaseDate = 1996},
                            new Discography {RecordName = "How Great Thou Art (with Bobbie Nelson)", ReleaseDate = 199 },
                            new Discography {RecordName = "Hill Country Christmas (with Bobbie Nelson)", ReleaseDate = 1997},
                            new Discography {RecordName = "Teatro", ReleaseDate = 1998},
                            new Discography {RecordName = "Night and Day", ReleaseDate = 1999},
                            new Discography {RecordName = "Tales Out of Luck (Me and the Drummer)", ReleaseDate = 2000},
                            new Discography {RecordName = "Milk Cow Blues", ReleaseDate = 2000},
                            new Discography {RecordName = "Rainbow Connection", ReleaseDate = 2001},
                            new Discography {RecordName = "The Great Divide", ReleaseDate = 2002},
                            new Discography {RecordName = "The Eyes of Texas (with Don Cherry)", ReleaseDate = 2002},
                            new Discography {RecordName = "Run That by Me One More Time (with Ray Price)", ReleaseDate = 2003},
                            new Discography {RecordName = "Nacogdoches", ReleaseDate = 2004},
                            new Discography {RecordName = "It Always Will Be", ReleaseDate = 2004},
                            new Discography {RecordName = "Countryman", ReleaseDate = 2005},
                            new Discography {RecordName = "You Don't Know Me: The Songs of Cindy Walker", ReleaseDate = 2006},
                            new Discography {RecordName = "Songbird", ReleaseDate = 2006},
                            new Discography {RecordName = "Last of the Breed (with Merle Haggard and Ray Price)", ReleaseDate = 2007},
                            new Discography {RecordName = "It's Magic (with Don Cherry)", ReleaseDate = 2007},
                            new Discography {RecordName = "Moment of Forever", ReleaseDate = 2008},
                            new Discography {RecordName = "Willie and the Wheel (with Asleep at the Wheel)", ReleaseDate = 2009},
                            new Discography {RecordName = "American Classic", ReleaseDate = 2009},
                            new Discography {RecordName = "Country Music", ReleaseDate = 2010},
                            new Discography {RecordName = "Remember Me, Vol. 1", ReleaseDate = 2011},
                            new Discography {RecordName = "Heroes", ReleaseDate = 2012},
                            new Discography {RecordName = "Let's Face the Music and Dance", ReleaseDate = 2013},
                            new Discography {RecordName = "To All the Girls...", ReleaseDate = 2013},
                            new Discography {RecordName = "Band of Brothers", ReleaseDate = 2014},
                            new Discography {RecordName = "December Day: Willie's Stash, Vol. 1 (with Bobbie Nelson)", ReleaseDate = 2014},
                            new Discography {RecordName = "Django & Jimmie (with Merle Haggard)", ReleaseDate = 2015},
                            new Discography {RecordName = "Summertime: Willie Nelson Sings Gershwin", ReleaseDate = 2016},
                            new Discography {RecordName = "For the Good Times: A Tribute to Ray Price", ReleaseDate = 2016},
                            new Discography {RecordName = "God's Problem Child", ReleaseDate = 2017},
                            new Discography {RecordName = "Willie and the Boys: Willie's Stash, Vol. 2 (with Lukas Nelson and Micah Nelson)", ReleaseDate = 2017},
                            new Discography {RecordName = "Last Man Standing", ReleaseDate = 2018},
                            new Discography {RecordName = "My Way", ReleaseDate = 2018},
                            new Discography {RecordName = "Ride Me Back Home", ReleaseDate = 2019},
                            new Discography {RecordName = "First Rose of Spring", ReleaseDate = 2020},
                            new Discography {RecordName = "The Willie Nelson Family (with Amy, Bobbie, Lukas, Micah, and Paula Nelson)", ReleaseDate = 2021},
                            new Discography {RecordName = "A Beautiful Time", ReleaseDate = 2022},
                            new Discography {RecordName = "I Don't Know a Thing About Love", ReleaseDate = 2023},
                            new Discography {RecordName = "Bluegrass", ReleaseDate = 2023}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Louis Armstrong",
                        Website = "https://www.louisarmstronghouse.org/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = trumpet}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Jazz Classics", ReleaseDate = 1944},
                            new Discography {RecordName = "Satchmo at Symphony Hall", ReleaseDate = 1951},
                            new Discography {RecordName = "Satchmo at Pasadena", ReleaseDate = 1951},
                            new Discography {RecordName = "Louis Armstrong Plays W.C. Handy", ReleaseDate = 1954},
                            new Discography {RecordName = "Louis Armstrong and the Mills Brothers, Volume One", ReleaseDate = 1954},
                            new Discography {RecordName = "Satch Plays Fats: A Tribute to the Immortal Fats Waller", ReleaseDate = 1955},
                            new Discography {RecordName = "Louis Armstrong at the Crescendo, Vol. 1", ReleaseDate = 1955},
                            new Discography {RecordName = "Satchmo Sings", ReleaseDate = 1955},
                            new Discography {RecordName = "Louis Armstrong and Eddie Condon at Newport", ReleaseDate = 1956},
                            new Discography {RecordName = "Satchmo the Great", ReleaseDate = 1956},
                            new Discography {RecordName = "An Evening with Louis Armstrong and His All Stars..Vols 1 & 2", ReleaseDate = 1956},
                            new Discography {RecordName = "Louis Armstrong and His All Stars – Ambassador Satch", ReleaseDate = 1956},
                            new Discography {RecordName = "Ella and Louis", ReleaseDate = 1956},
                            new Discography {RecordName = "Ella and Louis Again", ReleaseDate = 1957},
                            new Discography {RecordName = "Louis Armstrong Meets Oscar Peterson", ReleaseDate = 1957},
                            new Discography {RecordName = "Louis Under the Stars", ReleaseDate = 1957},
                            new Discography {RecordName = "Louis and the Angels", ReleaseDate = 1957},
                            new Discography {RecordName = "Porgy & Bess", ReleaseDate = 1958},
                            new Discography {RecordName = "Louis and the Good Book", ReleaseDate = 1958},
                            new Discography {RecordName = "Satchmo in Style", ReleaseDate = 1959},
                            new Discography {RecordName = "The Five Pennies", ReleaseDate = 1959},
                            new Discography {RecordName = "Satchmo Plays King Oliver", ReleaseDate = 1959},
                            new Discography {RecordName = "I've Got the World on a String", ReleaseDate = 1960},
                            new Discography {RecordName = "Bing & Satchmo", ReleaseDate = 1960},
                            new Discography {RecordName = "Recording Together for the First Time", ReleaseDate = 1961},
                            new Discography {RecordName = "The Great Reunion", ReleaseDate = 1961},
                            new Discography {RecordName = "The Real Ambassadors", ReleaseDate = 1962},
                            new Discography {RecordName = "Hello, Dolly!", ReleaseDate = 1964},
                            new Discography {RecordName = "Here's Louis Armstrong", ReleaseDate = 1968},
                            new Discography {RecordName = "Disney Songs the Satchmo Way", ReleaseDate = 1968},
                            new Discography {RecordName = "I Will Wait for You", ReleaseDate = 1968},
                            new Discography {RecordName = "What a Wonderful World", ReleaseDate = 1968},
                            new Discography {RecordName = "The One and Only", ReleaseDate = 1969},
                            new Discography {RecordName = "Louis 'Country & Western' Armstrong", ReleaseDate = 1970},
                            new Discography {RecordName = "Louis Armstrong and His Friends", ReleaseDate = 1971}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "John Lennon",
                        Website = "https://www.johnlennon.com/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = guitar}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Unfinished Music No. 1: Two Virgins (with Yoko Ono)", ReleaseDate = 1968},
                            new Discography {RecordName = "Unfinished Music No. 2: Life with the Lions (with Yoko Ono)", ReleaseDate = 1969},
                            new Discography {RecordName = "Wedding Album (with Yoko Ono)", ReleaseDate = 1969},
                            new Discography {RecordName = "John Lennon/Plastic Ono Band", ReleaseDate = 1970},
                            new Discography {RecordName = "Imagine", ReleaseDate = 1971},
                            new Discography {RecordName = "Some Time in New York City (with Yoko Ono)", ReleaseDate = 1972},
                            new Discography {RecordName = "Mind Games", ReleaseDate = 1973},
                            new Discography {RecordName = "Walls and Bridges", ReleaseDate = 1974},
                            new Discography {RecordName = "Rock 'n' Roll", ReleaseDate = 1975},
                            new Discography {RecordName = "Double Fantasy (with Yoko Ono)", ReleaseDate = 1980},
                            new Discography {RecordName = "Milk and Honey (posthumous; with Yoko Ono)", ReleaseDate = 1984} 
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Lars Ulrich",
                        Website = "https://en.wikipedia.org/wiki/Lars_Ulrich",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = drums}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Kill 'Em All", ReleaseDate = 1983},
                            new Discography {RecordName = "Ride the Lightning", ReleaseDate = 1984},
                            new Discography {RecordName = "Master of Puppets", ReleaseDate = 1986},
                            new Discography {RecordName = "...And Justice for All", ReleaseDate = 1988},
                            new Discography {RecordName = "Metallica", ReleaseDate = 1991},
                            new Discography {RecordName = "Load", ReleaseDate = 1996},
                            new Discography {RecordName = "Reload", ReleaseDate = 1997},
                            new Discography {RecordName = "St. Anger", ReleaseDate = 2003},
                            new Discography {RecordName = "Death Magnetic", ReleaseDate = 2008},
                            new Discography {RecordName = "Hardwired... to Self-Destruct", ReleaseDate = 2016},
                            new Discography {RecordName = "72 Seasons", ReleaseDate = 2023}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Dave Grohl",
                        Website = "https://en.wikipedia.org/wiki/Dave_Grohl",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = guitar}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Alive & Kicking", ReleaseDate = 1985},
                            new Discography {RecordName = "77 KK", ReleaseDate = 1985},
                            new Discography {RecordName = "Getting Shit for Growing Up Different", ReleaseDate = 1986},
                            new Discography {RecordName = "Demo 1", ReleaseDate = 1986},
                            new Discography {RecordName = "Demo 2", ReleaseDate = 1986},
                            new Discography {RecordName = "I Scream Not Coming Down", ReleaseDate = 1986},
                            new Discography {RecordName = "No More Censorship", ReleaseDate = 1988},
                            new Discography {RecordName = "Live at Van Hall in Amsterdam", ReleaseDate = 1988},
                            new Discography {RecordName = "Your Choice Live Series Vol.10", ReleaseDate = 1990},
                            new Discography {RecordName = "Fumble", ReleaseDate = 1993},
                            new Discography {RecordName = "Nevermind", ReleaseDate = 1991},
                            new Discography {RecordName = "Hormoaning", ReleaseDate = 1992},
                            new Discography {RecordName = "Incesticide", ReleaseDate = 1992},
                            new Discography {RecordName = "In Utero", ReleaseDate = 1993},
                            new Discography {RecordName = "MTV Unplugged in New York", ReleaseDate = 1994},
                            new Discography {RecordName = "Singles", ReleaseDate = 1996},
                            new Discography {RecordName = "From the Muddy Banks of the Wishkah", ReleaseDate = 1996},
                            new Discography {RecordName = "Nirvana", ReleaseDate = 2002},
                            new Discography {RecordName = "With the Lights Out", ReleaseDate = 2004},
                            new Discography {RecordName = "Sliver: The Best of the Box", ReleaseDate = 2005},
                            new Discography {RecordName = "Live at Reading", ReleaseDate = 2009},
                            new Discography {RecordName = "Icon", ReleaseDate = 2010},
                            new Discography {RecordName = "Pocketwatch", ReleaseDate = 1992},
                            new Discography {RecordName = "Foo Fighters", ReleaseDate = 1995},
                            new Discography {RecordName = "The Colour and the Shape", ReleaseDate = 1997},
                            new Discography {RecordName = "There Is Nothing Left to Lose", ReleaseDate = 1999},
                            new Discography {RecordName = "One by One", ReleaseDate = 2002},
                            new Discography {RecordName = "In Your Honor", ReleaseDate = 2005},
                            new Discography {RecordName = "Five Songs and a Cover", ReleaseDate = 2005},
                            new Discography {RecordName = "Skin and Bones", ReleaseDate = 2006},
                            new Discography {RecordName = "Echoes, Silence, Patience & Grace", ReleaseDate = 2007},
                            new Discography {RecordName = "Greatest Hits", ReleaseDate = 2009},
                            new Discography {RecordName = "Wasting Light", ReleaseDate = 2011},
                            new Discography {RecordName = "Medium Rare", ReleaseDate = 2011},
                            new Discography {RecordName = "Sonic Highways", ReleaseDate = 2014},
                            new Discography {RecordName = "Concrete and Gold", ReleaseDate = 2017},
                            new Discography {RecordName = "Medicine at Midnight", ReleaseDate = 2021},
                            new Discography {RecordName = "But Here We Are", ReleaseDate = 2023},
                            new Discography {RecordName = "Harlingtox Angel Divine", ReleaseDate = 1996},
                            new Discography {RecordName = "Tenacious D", ReleaseDate = 2001},
                            new Discography {RecordName = "Pick of Destiny", ReleaseDate = 2006},
                            new Discography {RecordName = "Rize of the Fenix", ReleaseDate = 2012},
                            new Discography {RecordName = "Post-Apocalypto", ReleaseDate = 2018},
                            new Discography {RecordName = "Songs for the Deaf", ReleaseDate = 2002},
                            new Discography {RecordName = "...Like Clockwork", ReleaseDate = 2013},
                            new Discography {RecordName = "Probot", ReleaseDate = 2004},
                            new Discography {RecordName = "Them Crooked Vultures", ReleaseDate = 2009},
                            new Discography {RecordName = "Hail Satin", ReleaseDate = 2021},
                            new Discography {RecordName = "Dream Widow", ReleaseDate = 2022},
                            new Discography {RecordName = "Play", ReleaseDate = 2018},
                            new Discography {RecordName = "Backbeat Music from the Motion Picture", ReleaseDate = 1994},
                            new Discography {RecordName = "The Pick of Destiny Soundtrack", ReleaseDate = 2006},
                            new Discography {RecordName = "Touch Music from the Motion Picture", ReleaseDate = 1997},
                            new Discography {RecordName = "Rising Sun: The Legend of Skateboarder Christian Hosoi Soundtrack", ReleaseDate = 2006},
                            new Discography {RecordName = "Sound City: Real to Reel Soundtrack", ReleaseDate = 2013}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Miles Davis",
                        Website = "https://en.wikipedia.org/wiki/Miles_Davis",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = trumpet}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "The New Sounds", ReleaseDate = 1951},
                            new Discography {RecordName = "Young Man with a Horn", ReleaseDate = 1953},
                            new Discography {RecordName = "Blue Period", ReleaseDate = 1953},
                            new Discography {RecordName = "The Compositions of Al Cohn", ReleaseDate = 1953},
                            new Discography {RecordName = "Miles Davis Volume 2", ReleaseDate = 1953},
                            new Discography {RecordName = "Miles Davis, Volume 3", ReleaseDate = 1954},
                            new Discography {RecordName = "Miles Davis Quartet", ReleaseDate = 1954},
                            new Discography {RecordName = "Miles Davis All Star Sextet", ReleaseDate = 1954},
                            new Discography {RecordName = "Miles Davis Quintet", ReleaseDate = 1954},
                            new Discography {RecordName = "Miles Davis with Sonny Rollins", ReleaseDate = 1954},
                            new Discography {RecordName = "Miles Davis All Stars, Volume 1", ReleaseDate = 1955},
                            new Discography {RecordName = "Miles Davis All Stars, Volume 2", ReleaseDate = 1955},
                            new Discography {RecordName = "The Musings of Miles", ReleaseDate = 1955},
                            new Discography {RecordName = "Blue Moods", ReleaseDate = 1955},
                            new Discography {RecordName = "Dig", ReleaseDate = 1956},
                            new Discography {RecordName = "Miles: The New Miles Davis Quintet", ReleaseDate = 1956},
                            new Discography {RecordName = "Miles Davis and Horns", ReleaseDate = 1956},
                            new Discography {RecordName = "Quintet / Sextet", ReleaseDate = 1956},
                            new Discography {RecordName = "Blue Haze", ReleaseDate = 1956},
                            new Discography {RecordName = "Collectors' Items", ReleaseDate = 1956},
                            new Discography {RecordName = "Walkin'", ReleaseDate = 1957},
                            new Discography {RecordName = "Cookin'", ReleaseDate = 1957},
                            new Discography {RecordName = "Bags' Groove", ReleaseDate = 1957},
                            new Discography {RecordName = "Relaxin'", ReleaseDate = 1958},
                            new Discography {RecordName = "Miles Davis and the Modern Jazz Giants", ReleaseDate = 1959},
                            new Discography {RecordName = "Workin'", ReleaseDate = 1960},
                            new Discography {RecordName = "Steamin'", ReleaseDate = 1961}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Kurt Cobain",
                        Website = "http://kurtcobain.com/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = guitar}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Bleach", ReleaseDate = 1989},
                            new Discography {RecordName = "Nevermind", ReleaseDate = 1991},
                            new Discography {RecordName = "In Utero", ReleaseDate = 1993}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Brian May",
                        Website = "https://brianmay.com/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = guitar}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Back to the Light", ReleaseDate = 1992},
                            new Discography {RecordName = "Another World", ReleaseDate = 1998},
                            new Discography {RecordName = "La musique de Furia", ReleaseDate = 2000}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Neil Peart",
                        Website = "https://neilpeart.net/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = drums}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Pieces Of Eight", ReleaseDate = 1987},
                            new Discography{RecordName = "Rush", ReleaseDate = 1974},
                            new Discography{RecordName = "Fly by Night", ReleaseDate = 1975},
                            new Discography{RecordName = "Caress of Steel", ReleaseDate = 1975},
                            new Discography{RecordName = "2112", ReleaseDate = 1976},
                            new Discography{RecordName = "A Farewell to Kings", ReleaseDate = 1977},
                            new Discography{RecordName = "Hemispheres", ReleaseDate = 1978},
                            new Discography{RecordName = "Permanent Waves", ReleaseDate = 1980},
                            new Discography{RecordName = "Moving Pictures", ReleaseDate = 1981},
                            new Discography{RecordName = "Signals", ReleaseDate = 1982},
                            new Discography{RecordName = "Grace Under Pressure", ReleaseDate = 1984},
                            new Discography{RecordName = "Power Windows", ReleaseDate = 1985},
                            new Discography{RecordName = "Hold Your Fire", ReleaseDate = 1987},
                            new Discography{RecordName = "Presto", ReleaseDate = 1989},
                            new Discography{RecordName = "Roll the Bones", ReleaseDate = 1991},
                            new Discography{RecordName = "Counterparts", ReleaseDate = 1993},
                            new Discography{RecordName = "Test for Echo", ReleaseDate = 1996},
                            new Discography{RecordName = "Vapor Trails", ReleaseDate = 2002},
                            new Discography{RecordName = "Snakes & Arrows", ReleaseDate = 2007},
                            new Discography{RecordName = "Clockwork Angels", ReleaseDate = 2012}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Tosin Abasi",
                        Website = "https://en.wikipedia.org/wiki/Tosin_Abasi",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = guitar}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Virus", ReleaseDate = 2001},
                            new Discography {RecordName = "Reflux", ReleaseDate = 2004},
                            new Discography {RecordName = "The Illusion of Democracy", ReleaseDate = 2004},
                            new Discography {RecordName = "Animals as Leaders", ReleaseDate = 2009},
                            new Discography {RecordName = "Wave of Babies (Digital Single)", ReleaseDate = 2010},
                            new Discography {RecordName = "Weightless", ReleaseDate = 2011},
                            new Discography {RecordName = "The Joy of Motion", ReleaseDate = 2014},
                            new Discography {RecordName = "Animals as Leaders Encore Edition", ReleaseDate = 2015},
                            new Discography {RecordName = "The Madness of Many", ReleaseDate = 2016},
                            new Discography {RecordName = "Parrhesia", ReleaseDate = 2022},
                            new Discography {RecordName = "Lingua Franca", ReleaseDate = 2012},
                            new Discography {RecordName = "The Call Within (Guitars in 'Vortex')", ReleaseDate = 2020}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Misha Mansoor",
                        Website = "https://en.wikipedia.org/wiki/Misha_Mansoor",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = guitar}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Periphery", ReleaseDate = 2010},
                            new Discography {RecordName = "Icarus EP", ReleaseDate = 2011},
                            new Discography {RecordName = "Periphery II: This Time It's Personal", ReleaseDate = 2012},
                            new Discography {RecordName = "Clear", ReleaseDate = 2014},
                            new Discography {RecordName = "Juggernaut: Alpha", ReleaseDate = 2015},
                            new Discography {RecordName = "Juggernaut: Omega", ReleaseDate = 2015},
                            new Discography {RecordName = "Periphery III: Select Difficulty", ReleaseDate = 2016},
                            new Discography {RecordName = "Periphery IV: Hail Stan", ReleaseDate = 2019},
                            new Discography {RecordName = "Periphery V: Djent Is Not a Genre", ReleaseDate = 2023},
                            new Discography {RecordName = "Archives: Volume 1", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 2", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 3", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 4", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 5", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 6", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 7", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 8", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Orchestral", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Electronic", ReleaseDate = 2020},
                            new Discography {RecordName = "Moderately Fast, Adequately Furious", ReleaseDate = 2021},
                            new Discography {RecordName = "Split EP with Cyclamen", ReleaseDate = 2010},
                            new Discography {RecordName = "Viscera", ReleaseDate = 2015},
                            new Discography {RecordName = "Void", ReleaseDate = 2022},
                            new Discography {RecordName = "The Vacancy", ReleaseDate = 2018}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Adam Getgood",
                        Website = "https://www.getgooddrums.com/pages/about-us",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = bass}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Periphery", ReleaseDate = 2010},
                            new Discography {RecordName = "Icarus EP", ReleaseDate = 2011},
                            new Discography {RecordName = "Periphery II: This Time It's Personal", ReleaseDate = 2012},
                            new Discography {RecordName = "Clear", ReleaseDate = 2014},
                            new Discography {RecordName = "Juggernaut: Alpha", ReleaseDate = 2015},
                            new Discography {RecordName = "Juggernaut: Omega", ReleaseDate = 2015},
                            new Discography {RecordName = "Periphery III: Select Difficulty", ReleaseDate = 2016},
                            new Discography {RecordName = "Periphery IV: Hail Stan", ReleaseDate = 2019},
                            new Discography {RecordName = "Periphery V: Djent Is Not a Genre", ReleaseDate = 2023},
                            new Discography {RecordName = "Archives: Volume 1", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 2", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 3", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 4", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 5", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 6", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 7", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 8", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Orchestral", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Electronic", ReleaseDate = 2020},
                            new Discography {RecordName = "Moderately Fast, Adequately Furious", ReleaseDate = 2021},
                            new Discography {RecordName = "Split EP with Cyclamen", ReleaseDate = 2010},
                            new Discography {RecordName = "Viscera", ReleaseDate = 2015},
                            new Discography {RecordName = "Void", ReleaseDate = 2022},
                            new Discography {RecordName = "The Vacancy", ReleaseDate = 2018}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Matt Halpern",
                        Website = "https://en.wikipedia.org/wiki/Matt_Halpern",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = drums}
                        },
                        Discography = new List<Discography> {
                            new Discography{RecordName = "Spinfire", ReleaseDate = 2000},
                            new Discography{RecordName = "Forces", ReleaseDate = 2008},
                            new Discography{RecordName = "Periphery", ReleaseDate = 2010},
                            new Discography{RecordName = "Periphery II: This Time It's Personal", ReleaseDate = 2012},
                            new Discography{RecordName = "Juggernaut: Alpha", ReleaseDate = 2015},
                            new Discography{RecordName = "Juggernaut: Omega", ReleaseDate = 2015},
                            new Discography{RecordName = "Periphery III: Select Difficulty", ReleaseDate = 2016},
                            new Discography{RecordName = "Periphery IV: Hail Stan", ReleaseDate = 2019},
                            new Discography{RecordName = "Periphery V: Djent Is Not a Genre", ReleaseDate = 2023}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Mark Holcomb",
                        Website = "https://en.wikipedia.org/wiki/Periphery_(band)",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = guitar}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Periphery", ReleaseDate = 2010},
                            new Discography {RecordName = "Icarus EP", ReleaseDate = 2011},
                            new Discography {RecordName = "Periphery II: This Time It's Personal", ReleaseDate = 2012},
                            new Discography {RecordName = "Clear", ReleaseDate = 2014},
                            new Discography {RecordName = "Juggernaut: Alpha", ReleaseDate = 2015},
                            new Discography {RecordName = "Juggernaut: Omega", ReleaseDate = 2015},
                            new Discography {RecordName = "Periphery III: Select Difficulty", ReleaseDate = 2016},
                            new Discography {RecordName = "Periphery IV: Hail Stan", ReleaseDate = 2019},
                            new Discography {RecordName = "Periphery V: Djent Is Not a Genre", ReleaseDate = 2023},
                            new Discography {RecordName = "Archives: Volume 1", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 2", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 3", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 4", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 5", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 6", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 7", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 8", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Orchestral", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Electronic", ReleaseDate = 2020},
                            new Discography {RecordName = "Moderately Fast, Adequately Furious", ReleaseDate = 2021},
                            new Discography {RecordName = "Split EP with Cyclamen", ReleaseDate = 2010},
                            new Discography {RecordName = "Viscera", ReleaseDate = 2015},
                            new Discography {RecordName = "Void", ReleaseDate = 2022},
                            new Discography {RecordName = "The Vacancy", ReleaseDate = 2018}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Jake Bowen",
                        Website = "https://en.wikipedia.org/wiki/Periphery_(band)",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = guitar}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Periphery", ReleaseDate = 2010},
                            new Discography {RecordName = "Icarus EP", ReleaseDate = 2011},
                            new Discography {RecordName = "Periphery II: This Time It's Personal", ReleaseDate = 2012},
                            new Discography {RecordName = "Clear", ReleaseDate = 2014},
                            new Discography {RecordName = "Juggernaut: Alpha", ReleaseDate = 2015},
                            new Discography {RecordName = "Juggernaut: Omega", ReleaseDate = 2015},
                            new Discography {RecordName = "Periphery III: Select Difficulty", ReleaseDate = 2016},
                            new Discography {RecordName = "Periphery IV: Hail Stan", ReleaseDate = 2019},
                            new Discography {RecordName = "Periphery V: Djent Is Not a Genre", ReleaseDate = 2023},
                            new Discography {RecordName = "Archives: Volume 1", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 2", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 3", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 4", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 5", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 6", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 7", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Volume 8", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Orchestral", ReleaseDate = 2020},
                            new Discography {RecordName = "Archives: Electronic", ReleaseDate = 2020},
                            new Discography {RecordName = "Moderately Fast, Adequately Furious", ReleaseDate = 2021},
                            new Discography {RecordName = "Split EP with Cyclamen", ReleaseDate = 2010},
                            new Discography {RecordName = "Viscera", ReleaseDate = 2015},
                            new Discography {RecordName = "Void", ReleaseDate = 2022},
                            new Discography {RecordName = "The Vacancy", ReleaseDate = 2018}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "B.B King",
                        Website = "https://bbking.com/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = guitar}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Mr. Blues", ReleaseDate = 1962},
                            new Discography {RecordName = "Confessin' the Blues", ReleaseDate = 1966},
                            new Discography {RecordName = "Blues on Top of Blues", ReleaseDate = 1968},
                            new Discography {RecordName = "Lucille", ReleaseDate = 1968},
                            new Discography {RecordName = "Live & Well", ReleaseDate = 1969},
                            new Discography {RecordName = "Completely Well", ReleaseDate = 1969},
                            new Discography {RecordName = "Indianola Mississippi Seeds", ReleaseDate = 1970},
                            new Discography {RecordName = "B.B. King in London", ReleaseDate = 1971},
                            new Discography {RecordName = "L.A. Midnight", ReleaseDate = 1972},
                            new Discography {RecordName = "Guess Who", ReleaseDate = 1972},
                            new Discography {RecordName = "To Know You Is to Love You", ReleaseDate = 1973},
                            new Discography {RecordName = "Friends", ReleaseDate = 1974},
                            new Discography {RecordName = "Lucille Talks Back", ReleaseDate = 1975},
                            new Discography {RecordName = "King Size", ReleaseDate = 1977},
                            new Discography {RecordName = "Midnight Believer", ReleaseDate = 1978},
                            new Discography {RecordName = "Take It Home", ReleaseDate = 1979},
                            new Discography {RecordName = "There Must Be a Better World Somewhere", ReleaseDate = 1981},
                            new Discography {RecordName = "Love Me Tender", ReleaseDate = 1982},
                            new Discography {RecordName = "Blues 'N' Jazz", ReleaseDate = 1983},
                            new Discography {RecordName = "Six Silver Strings", ReleaseDate = 1985},
                            new Discography {RecordName = "King of the Blues: 1989", ReleaseDate = 1988},
                            new Discography {RecordName = "There Is Always One More Time", ReleaseDate = 1991},
                            new Discography {RecordName = "Blues Summit", ReleaseDate = 1993},
                            new Discography {RecordName = "Diane Schuur & B.B. King - Heart to Heart", ReleaseDate = 1994},
                            new Discography {RecordName = "Lucille & Friends", ReleaseDate = 1995},
                            new Discography {RecordName = "Deuces Wild", ReleaseDate = 1997},
                            new Discography {RecordName = "Blues on the Bayou", ReleaseDate = 1998},
                            new Discography {RecordName = "Let the Good Times Roll", ReleaseDate = 1999},
                            new Discography {RecordName = "B.B. King & Eric Clapton - Riding with the King", ReleaseDate = 2000},
                            new Discography {RecordName = "Makin' Love Is Good for You", ReleaseDate = 2000},
                            new Discography {RecordName = "A Christmas Celebration of Hope", ReleaseDate = 2001},
                            new Discography {RecordName = "20th Century Masters/The Christmas Collection: The Best of B.B. King", ReleaseDate = 2003},
                            new Discography {RecordName = "Reflections", ReleaseDate = 2003},
                            new Discography {RecordName = "B.B. King & Friends: 80", ReleaseDate = 2005},
                            new Discography {RecordName = "One Kind Favor", ReleaseDate = 2008}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Carlos Santana",
                        Website = "https://www.santana.com/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = guitar}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Love Devotion Surrender", ReleaseDate = 1973},
                            new Discography {RecordName = "Illuminations", ReleaseDate = 1974},
                            new Discography {RecordName = "Oneness — Silver Dreams Golden Reality", ReleaseDate = 1979},
                            new Discography {RecordName = "The Swing of Delight", ReleaseDate = 1980},
                            new Discography {RecordName = "Havana Moon", ReleaseDate = 1983},
                            new Discography {RecordName = "Blues for Salvador", ReleaseDate = 1987},
                            new Discography {RecordName = "Santana Brothers", ReleaseDate = 1994}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Wynton Marsalis",
                        Website = "https://wyntonmarsalis.org/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = trumpet}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Love Devotion Surrender", ReleaseDate = 1973},
                            new Discography {RecordName = "Illuminations", ReleaseDate = 1974},
                            new Discography {RecordName = "Oneness — Silver Dreams Golden Reality", ReleaseDate = 1979},
                            new Discography {RecordName = "The Swing of Delight", ReleaseDate = 1980},
                            new Discography {RecordName = "Havana Moon", ReleaseDate = 1983},
                            new Discography {RecordName = "Blues for Salvador", ReleaseDate = 1987},
                            new Discography {RecordName = "Santana Brothers", ReleaseDate = 1994},
                            new Discography {RecordName = "Supernatural", ReleaseDate = 1999},
                            new Discography {RecordName = "Shaman", ReleaseDate = 2002},
                            new Discography {RecordName = "All That I Am", ReleaseDate = 2005},
                            new Discography {RecordName = "Guitar Heaven: The Greatest Guitar Classics of All Time", ReleaseDate = 2010},
                            new Discography {RecordName = "Shape Shifter", ReleaseDate = 2012},
                            new Discography {RecordName = "Corazón", ReleaseDate = 2014},
                            new Discography {RecordName = "Santana IV", ReleaseDate = 2016},
                            new Discography {RecordName = "Africa Speaks", ReleaseDate = 2019},
                            new Discography {RecordName = "Blessings and Miracles", ReleaseDate = 2021}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Yo-Yo Ma",
                        Website = "https://www.yo-yoma.com/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = cello}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Love Devotion Surrender", ReleaseDate = 1973},
                            new Discography {RecordName = "Illuminations", ReleaseDate = 1974},
                            new Discography {RecordName = "Oneness — Silver Dreams Golden Reality", ReleaseDate = 1979},
                            new Discography {RecordName = "The Swing of Delight", ReleaseDate = 1980},
                            new Discography {RecordName = "Havana Moon", ReleaseDate = 1983},
                            new Discography {RecordName = "Blues for Salvador", ReleaseDate = 1987},
                            new Discography {RecordName = "Santana Brothers", ReleaseDate = 1994},
                            new Discography {RecordName = "Supernatural", ReleaseDate = 1999},
                            new Discography {RecordName = "Shaman", ReleaseDate = 2002},
                            new Discography {RecordName = "All That I Am", ReleaseDate = 2005},
                            new Discography {RecordName = "Guitar Heaven: The Greatest Guitar Classics of All Time", ReleaseDate = 2010},
                            new Discography {RecordName = "Shape Shifter", ReleaseDate = 2012},
                            new Discography {RecordName = "Corazón", ReleaseDate = 2014},
                            new Discography {RecordName = "Santana IV", ReleaseDate = 2016},
                            new Discography {RecordName = "Africa Speaks", ReleaseDate = 2019},
                            new Discography {RecordName = "Blessings and Miracles", ReleaseDate = 2021}            
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Joshua Bell",
                        Website = "https://joshuabell.com/",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = violin}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Bruch & Mendelssohn Violin Concertos", ReleaseDate = 1988},
                            new Discography {RecordName = "Fauré / Debussy / Franck Violin Sonatas with Jean-Yves Thibaudet", ReleaseDate = 1989},
                            new Discography {RecordName = "Saint-Saëns: Violin concerto N°3, Lalo, Symphonie Espagnole", ReleaseDate = 1989},
                            new Discography {RecordName = "Presenting Joshua Bell", ReleaseDate = 1990},
                            new Discography {RecordName = "Chausson Concerto, Ravel Piano Trio", ReleaseDate = 1991},
                            new Discography {RecordName = "Saint-Saëns: Violin Concerto No. 3 / Chausson: Poeme", ReleaseDate = 1992},
                            new Discography {RecordName = "Prokofiev: Violin Concertos & Sonatas", ReleaseDate = 1995},
                            new Discography {RecordName = "Brahms / Schumann Violin Concertos", ReleaseDate = 1995},
                            new Discography {RecordName = "The Kreisler Album", ReleaseDate = 1996},
                            new Discography {RecordName = "Barber / Walton/ Bloch Violin Concertos", ReleaseDate = 1997},
                            new Discography {RecordName = "Shostakovich Piano Trio No. 2", ReleaseDate = 1997},
                            new Discography {RecordName = "Maw Violin Concertos", ReleaseDate = 1999},
                            new Discography {RecordName = "Gershwin Fantasy", ReleaseDate = 1999},
                            new Discography {RecordName = "Sibelius & Goldmark: Violin Concertos", ReleaseDate = 2000},
                            new Discography {RecordName = "Short Trip Home", ReleaseDate = 2000},
                            new Discography {RecordName = "Bernstein West Side Story Suite", ReleaseDate = 2001},
                            new Discography {RecordName = "Beethoven & Mendelssohn: Violin Concertos", ReleaseDate = 2002},
                            new Discography {RecordName = "Romance of the Violin", ReleaseDate = 2004},
                            new Discography {RecordName = "Tchaikovsky: Violin Concerto, Op. 35; Melodie; Danse Russe from Swan Lake", ReleaseDate = 2005},
                            new Discography {RecordName = "OST Duft von Lavendel", ReleaseDate = 2005},
                            new Discography {RecordName = "Voice of the Violin", ReleaseDate = 2006},
                            new Discography {RecordName = "Corigliano The Red Violin", ReleaseDate = 2007},
                            new Discography {RecordName = "The Essential Joshua Bell", ReleaseDate = 2007},
                            new Discography {RecordName = "Vivaldi: The Four Seasons", ReleaseDate = 2008},
                            new Discography {RecordName = "Bruch, Mendelssohn, Mozart Violin Concertos", ReleaseDate = 2009},
                            new Discography {RecordName = "The Best of Joshua Bell", ReleaseDate = 2009},
                            new Discography {RecordName = "At Home with Friends", ReleaseDate = 2009},
                            new Discography {RecordName = "French Impressions", ReleaseDate = 2012},
                            new Discography {RecordName = "Beethoven: Symphonies Nos.4 &7", ReleaseDate = 2013},
                            new Discography {RecordName = "Musical Gifts from Joshua Bell and Friends", ReleaseDate = 2013},
                            new Discography {RecordName = "Bach", ReleaseDate = 2014},
                            new Discography {RecordName = "For the Love of Brahms", ReleaseDate = 2016},
                            new Discography {RecordName = "Joshua Bell – The Classical Collection", ReleaseDate = 2017},
                            new Discography {RecordName = "Brigitte Klassik zum Genießen: Joshua Bell", ReleaseDate = 2017},
                            new Discography {RecordName = "Bruch: Scottish Fantasy, Op. 46 / Violin Concerto No. 1 in G Minor, Op. 26", ReleaseDate = 2018},
                            new Discography {RecordName = "At Home With Music", ReleaseDate = 2020}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Benny Goodman",
                        Website = "https://en.wikipedia.org/wiki/Benny_Goodman",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = clarinet}
                        },
                        Discography = new List<Discography> {
                            new Discography {RecordName = "Swinging 34 Vols. 1 & 2", ReleaseDate = 1934},
                            new Discography {RecordName = "Original Benny Goodman Trio and Quartet Sessions, Vol. 1: After You've Gone", ReleaseDate = 1935},
                            new Discography {RecordName = "Stomping at the Savoy", ReleaseDate = 1935},
                            new Discography {RecordName = "Air Play", ReleaseDate = 1936},
                            new Discography {RecordName = "Sing, Sing, Sing (With a Swing)", ReleaseDate = 1937},
                            new Discography {RecordName = "Roll 'Em, Vol. 1", ReleaseDate = 1937},
                            new Discography {RecordName = "Roll 'Em, Vol. 2", ReleaseDate = 1937},
                            new Discography {RecordName = "Don't Be That Way", ReleaseDate = 1938},
                            new Discography {RecordName = "From Spirituals to Swing", ReleaseDate = 1938},
                            new Discography {RecordName = "The Famous 1938 Carnegie Hall Jazz Concert Vols. 1–3", ReleaseDate = 1938},
                            new Discography {RecordName = "Mozart Clarinet Quintet, with the Budapest String Quartet", ReleaseDate = 1938},
                            new Discography {RecordName = "Eddie Sauter Arrangements", ReleaseDate = 1940},
                            new Discography {RecordName = "Swing into Spring", ReleaseDate = 1941},
                            new Discography {RecordName = "Benny Goodman Sextet", ReleaseDate = 1944},
                            new Discography {RecordName = "Undercurrent Blues", ReleaseDate = 1947},
                            new Discography {RecordName = "Swedish Pastry", ReleaseDate = 1948},
                            new Discography {RecordName = "Session for Six", ReleaseDate = 1950},
                            new Discography {RecordName = "The Benny Goodman Trio Plays", ReleaseDate = 1951},
                            new Discography {RecordName = "Goodman & Teagarden", ReleaseDate = 1951},
                            new Discography {RecordName = "Easy Does It", ReleaseDate = 1952}
                        }
                    },
                    new Musician
                    {
                        MusicianName = "Ron Carter",
                        Website = "https://en.wikipedia.org/wiki/Ron_Carter",
                        MusicianInstruments = new List<MusicianInstrument> {
                            new MusicianInstrument {Instrument = doublebass}
                        },
                        Discography = new List<Discography> {
                            new Discography{RecordName = "Where?", ReleaseDate = 1961},
                            new Discography{RecordName = "Uptown Conversation", ReleaseDate = 1969},
                            new Discography{RecordName = "Alone Together with Jim Hall", ReleaseDate = 1972},
                            new Discography{RecordName = "Blues Farm", ReleaseDate = 1973},
                            new Discography{RecordName = "All Blues", ReleaseDate = 1973},
                            new Discography{RecordName = "Spanish Blue", ReleaseDate = 1974},
                            new Discography{RecordName = "Anything Goes", ReleaseDate = 1975},
                            new Discography{RecordName = "Yellow & Green", ReleaseDate = 1976},
                            new Discography{RecordName = "Pastels", ReleaseDate = 1976},
                            new Discography{RecordName = "Piccolo", ReleaseDate = 1977},
                            new Discography{RecordName = "Third Plane", ReleaseDate = 1977},
                            new Discography{RecordName = "Peg Leg", ReleaseDate = 1977},
                            new Discography{RecordName = "A Song for You", ReleaseDate = 1978},
                            new Discography{RecordName = "1 + 3 with Hank Jones or Herbie Hancock and Tony Williams", ReleaseDate = 1978},
                            new Discography{RecordName = "Skyline with Jack DeJohnette, Gonzalo Rubalcaba", ReleaseDate = 2018},
                            new Discography{RecordName = "Foursight: The Complete Stockholm Tapes", ReleaseDate = 2018},
                            new Discography{RecordName = "Remembering Bob Freedman", ReleaseDate = 2019},
                            new Discography{RecordName = "The Brown Beatnik Tomes with Danny Simmons", ReleaseDate = 2019},
                            new Discography{RecordName = "Finding The Right Notes", ReleaseDate = 2021}
                        }
                    } 
                );
                
                context.SaveChanges();
            }
        }

        // support to create an Instrument and save it to the database. 
        private static Instrument GetOrCreateInstrument(MusicianDbContext context, string instrumentName)
        {
            var instrument = context.Instruments.FirstOrDefault(i => i.InstrumentName == instrumentName);
            if (instrument == null)
            {
                instrument = new Instrument {InstrumentName = instrumentName};
                context.Instruments.Add(instrument);
                context.SaveChanges();
            }
            return instrument;
        }
    }
}

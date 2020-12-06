using System.Collections.Generic;

namespace Localman.NET
{
    /// <summary>Class <c>Localman</c> is used to get details from States and LGAs in Nigeria
    ///.</summary>
    ///
    public class Localman
    {

        private List<StateDetails> StateDetails { get; }

        public Localman()
        {
            StateDetails = JsonReader.GetStateDetails();
        }


        /// <summary>Returns an ArrayList of all the States in Nigeria.
        ///    
        /// <example>For example:
        /// <code>
        ///    Localman localman = new Localman();
        ///    localman.GelAllStates();
        /// </code>
        /// results in <c>localman</c>'s having return  an arraylist of string that contains all the states in Nigeria.
        /// </example>
        /// </summary>
        public List<string> GetAllStates()
        {
            var states = new List<string>();

            foreach (var item in StateDetails)
            {
                states.Add(item.Name);
            }

            return states;
        }

        /// <summary>Returns an ArrayList of all the Local Government Areas in Nigeria.
        ///    
        /// <example>For example:
        /// <code>
        ///    Localman localman = new Localman();
        ///    localman.GetAllLGAs();
        /// </code>
        /// results in <c>localman</c>'s having return  an arraylist of string that contains all the LGAs in Nigeria.
        /// </example>
        /// </summary>
        public List<string> GetAllLGAs()
        {
            var lgas = new List<string>();

            foreach (var item in StateDetails)
            {
                foreach (var lga in item.Lgas)
                {
                    lgas.Add(lga);
                }
            }

            return lgas;
        }


        /// <summary> Returns an ArrayList of all Local Government Areas (LGAs) in a state.
        ///    
        /// <example>For example:
        /// <code>
        ///    Localman localman = new Localman();
        ///    localman.GetLGAs(State.LAGOS);
        /// </code>
        /// <param name="state">State .</param>
        /// results in <c>localman</cEnum>'s having return  an arraylist of string that contains all the LGAs in a State.
        /// </example>
        /// </summary>
        public List<string> GetLGAs(State state)
        {

            var stateName = state.GetDescription();
            var lga = new List<string>();

            foreach (var item in StateDetails)
            {
                if (item.Name == stateName)
                {
                    lga = item.Lgas;
                    break;
                }
            }


            return lga;
        }

        /// <summary> Returns an capital of a State.
        ///    
        /// <example>For example:
        /// <code>
        ///    Localman localman = new Localman();
        ///    localman.GetCapital(State.LAGOS);
        /// </code>
        /// <param name="state">State .</param>
        /// results in <c>localman</cEnum>'s having return capital of a state.
        /// </example>
        /// </summary>
        public string GetCapital(State state)
        {
            string capital = string.Empty;
            var value = state.GetDescription();
            foreach (var item in StateDetails)
            {
                if (item.Name == value)
                {
                    capital = item.Capital;
                    break;
                }
            }

            return capital;
        }

        /// <summary> Returns the state a local government area is found in.
        ///    
        /// <example>For example:
        /// <code>
        ///    Localman localman = new Localman();
        ///    localman.GetLGAState("Ikorodu");
        /// </code>
        /// <param name="lga">Put in an LGA .</param>
        /// <returns>A string representing a state.</returns>
        /// <returns>Null if state not found.</returns>
        /// results in <c>localman</cEnum>'s having return capital of a state.
        /// </example>
        /// </summary>
        public string GetLGAState(string lga)
        {
            var state = string.Empty;
            foreach (var item in StateDetails)
            {
                foreach (var lgaInState in item.Lgas)
                {
                    if (lgaInState == lga)
                    {
                        state = item.Name;
                        break;

                    }
                }
            }

            return state;
        }


        /// <summary> Returns the latitude of a state.
        ///    
        /// <example>For example:
        /// <code>
        ///    Localman localman = new Localman();
        ///    localman.GetLatitude(State.LAGOS);
        /// </code>
        /// <param name="state">Put in a State enum .</param>
        /// <returns>A double representing latitude of a state.</returns>
        /// </example>
        /// </summary>
        public double GetLatitude(State state)
        {
            double latitude = 0.0;
            var value = state.GetDescription();

            foreach (var item in StateDetails)
            {
                if (item.Name == value)
                {
                    latitude = item.Latitude;
                    break;
                }
            }

            return latitude;
        }

        /// <summary> Returns the longitude of a state.
        ///    
        /// <example>For example:
        /// <code>
        ///    Localman localman = new Localman();
        ///    localman.GetLongitude(State.LAGOS);
        /// </code>
        /// <param name="state">Put in a State enum .</param>
        /// <returns>A double representing longitude of a state.</returns>
        /// </example>
        /// </summary>
        public double GetLongitude(State state)
        {
            double longitude = 0.0;
            var value = state.GetDescription();

            foreach (var item in StateDetails)
            {
                if (item.Name == value)
                {
                    longitude = item.Longitude;
                    break;
                }
            }

            return longitude;
        }


        /// <summary> Returns the maximum latitude of a state.
        ///    
        /// <example>For example:
        /// <code>
        ///    Localman localman = new Localman();
        ///    localman.GetLongitude(State.LAGOS);
        /// </code>
        /// <param name="state">Put in a State enum .</param>
        /// <returns>A double representing maximum latitude of a state.</returns>
        /// </example>
        /// </summary>
        public double GetMaxLatitude(State state)
        {
            double latitude = 0.0;
            var value = state.GetDescription();

            foreach (var item in StateDetails)
            {
                if (item.Name == value)
                {
                    latitude = item.MaxLat;
                    break;
                }
            }

            return latitude;
        }

        /// <summary> Returns the maximum longitude of a state.
        ///    
        /// <example>For example:
        /// <code>
        ///    Localman localman = new Localman();
        ///    localman.GetMaxLongitude(State.LAGOS);
        /// </code>
        /// <param name="state">Put in a State enum .</param>
        /// <returns>A double representing maximum longitude of a state.</returns>
        /// </example>
        /// </summary>
        public double GetMaxLongitude(State state)
        {
            double longitude = 0.0;
            var value = state.GetDescription();

            foreach (var item in StateDetails)
            {
                if (item.Name == value)
                {
                    longitude = item.MaxLong;
                    break;
                }
            }

            return longitude;
        }


        /// <summary> Returns the minimum latitude of a state.
        ///    
        /// <example>For example:
        /// <code>
        ///    Localman localman = new Localman();
        ///    localman.GetMinLatitude(State.LAGOS);
        /// </code>
        /// <param name="state">Put in a State enum .</param>
        /// <returns>A double representing minimum latitude of a state.</returns>
        /// </example>
        /// </summary>
        public double GetMinLatitude(State state)
        {
            double latitude = 0.0;
            var value = state.GetDescription();

            foreach (var item in StateDetails)
            {
                if (item.Name == value)
                {
                    latitude = item.MinLat;
                    break;
                }
            }

            return latitude;
        }


        /// <summary> Returns the minimum longitude of a state.
        ///    
        /// <example>For example:
        /// <code>
        ///    Localman localman = new Localman();
        ///    localman.GetMinLongitude(State.LAGOS);
        /// </code>
        /// <param name="state">Put in a State enum .</param>
        /// <returns>A double representing minimum longitude of a state.</returns>
        /// </example>
        /// </summary>
        public double GetMinLongitude(State state)
        {
            double longitude = 0.0;
            var value = state.GetDescription();

            foreach (var item in StateDetails)
            {
                if (item.Name == value)
                {
                    longitude = item.MinLong;
                    break;
                }
            }

            return longitude;
        }
    }
}

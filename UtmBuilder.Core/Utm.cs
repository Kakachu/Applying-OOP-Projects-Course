﻿using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core
{
	public class Utm
	{
        public Utm(Url url, Campaign campaign)
        {
            Url = url;
            Campaign = campaign;
        }

        /// <summary>
        /// URL (Website Link)
        /// </summary>
        public Url Url { get; private set; }

        /// <summary>
        ///  Campaign Details
        /// </summary>
        public Campaign Campaign { get; private set; }
	}
}

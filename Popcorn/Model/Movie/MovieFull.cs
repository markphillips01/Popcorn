﻿using System.Collections.Generic;
using Popcorn.Model.Movie.Json;

namespace Popcorn.Model.Movie
{
    /// <summary>
    /// Represents all of the movie's details
    /// </summary>
    public class MovieFull : MovieFullDeserialized
    {
        #region Properties

        #region Property -> Title
        /// <summary>
        /// Movie's title
        /// </summary>
        public new string Title
        {
            get { return base.Title; }
            set { Set(() => Title, ref base.Title, value); }
        }
        #endregion

        #region Property -> DescriptionFull
        /// <summary>
        /// Movie's full description
        /// </summary>
        public new string DescriptionFull
        {
            get { return base.DescriptionFull; }
            set { Set(() => DescriptionFull, ref base.DescriptionFull, value); }
        }
        #endregion

        #region Property -> Genres
        /// <summary>
        /// Movie's genres
        /// </summary>
        public new IEnumerable<string> Genres
        {
            get { return base.Genres; }
            set { Set(() => Genres, ref base.Genres, value); }
        }
        #endregion

        #region Property -> BackgroundImagePath
        /// <summary>
        /// Local path of the downloaded movie's background image
        /// </summary>
        private string _backgroundImagePath = string.Empty;
        /// <summary>
        /// Local path of the downloaded movie's background image
        /// </summary>
        public string BackgroundImagePath
        {
            get { return _backgroundImagePath; }
            set { Set(() => BackgroundImagePath, ref _backgroundImagePath, value); }
        }
        #endregion

        #region Property -> PosterImagePath
        /// <summary>
        /// Local path of the downloaded movie's poster image
        /// </summary>
        private string _posterImagePath = string.Empty;
        /// <summary>
        /// Local path of the downloaded movie's poster image
        /// </summary>
        public string PosterImagePath
        {
            get { return _posterImagePath; }
            set { Set(() => PosterImagePath, ref _posterImagePath, value); }
        }
        #endregion

        #region Property -> WatchInFullHdQuality
        /// <summary>
        /// Decide if movie has to be watched in full HQ or not
        /// </summary>
        private bool _watchInFullHdQuality;
        /// <summary>
        /// Decide if movie has to be watched in full HQ or not
        /// </summary>
        public bool WatchInFullHdQuality
        {
            get { return _watchInFullHdQuality; }
            set { Set(() => WatchInFullHdQuality, ref _watchInFullHdQuality, value); }
        }
        #endregion

        #region Property -> FullHdAvailable
        /// <summary>
        /// Indicate if full HQ quality is available
        /// </summary>
        private bool _fullHdAvailable;
        /// <summary>
        /// Indicate if full HQ quality is available
        /// </summary>
        public bool FullHdAvailable
        {
            get { return _fullHdAvailable; }
            set { Set(() => FullHdAvailable, ref _fullHdAvailable, value); }
        }
        #endregion

        #endregion
    }
}

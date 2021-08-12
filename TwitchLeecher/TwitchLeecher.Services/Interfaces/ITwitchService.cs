using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using TwitchLeecher.Core.Models;

namespace TwitchLeecher.Services.Interfaces
{
    public interface ITwitchService
    {
        #region Properties

        List<TwitchVideo> Videos { get; set; }

        List<TwitchVideoDownload> Downloads { get; set; }

        #endregion Properties

        #region Methods

        VodAuthInfo RetrieveVodAuthInfo(string id);

        bool ChannelExists(string channel);

        string GetChannelIdByName(string channel);

        void Search(string urls);

        void Enqueue(DownloadParameters downloadParams);

        void Cancel(string id);

        void Retry(string id);

        void Remove(string id);

        void Pause();

        void Resume();

        bool CanShutdown();

        void Shutdown();

        bool IsFileNameUsed(string fullPath);

        void Download();

        void SearchUrls(string urls);

        #endregion Methods
    }
}
using Windows.UI.Core;

namespace ProjectQuebec.Fluent.UICode
{
    interface IPage
    {
        int ViewId { get; set; }
        void RemoveFile();
        CoreDispatcher Dispatcher { get; }
    }
}

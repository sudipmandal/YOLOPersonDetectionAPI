using Compunet.YoloSharp;
using YoloPersonDetectionAPI.Models;

namespace YoloPersonDetectionAPI.Services
{
    public class LocalCacheService : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            LocalCache.predictor = new YoloPredictor("Assets/yolo11n.onnx");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            LocalCache.predictor.Dispose();
            return Task.CompletedTask;
        }
    }
}

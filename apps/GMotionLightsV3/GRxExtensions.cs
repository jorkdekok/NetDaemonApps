namespace GMotionLightsV3.RxExtensions
{
    public static class GRxExtensions
    {
        public static IObservable<TriggerEvent> MyTimeout1(this IObservable<TriggerEvent> source, TimeSpan timeout)
        {
            // emit AanTimeout state value and concat orginal source to continue stream
            //var newSource = Observable.Defer(
            //	() => Observable.Return(new TriggerEvent(TriggerStates.AanTimeout)).Concat(source)
            //	);
            var newSource = Observable.Defer(
                () => Observable.Return(new TriggerEvent(TriggerStates.AanTimeout)).Merge(source)
                );
            return source.Timeout(
                timeout,
                newSource
            );
        }

        public static IObservable<T> MyTimeout2<T>(this IObservable<T> source, TimeSpan timeout, T returnValue)
        {
            // emit returnValue and concat orginal source to continue stream
            var newSource = Observable.Return<T>(returnValue).Concat(source);
            return source.Timeout(
                timeout,
                newSource
            );
        }

        public static IObservable<T> MyTimeout3<T>(this IObservable<T> source, TimeSpan timeout, Func<T> returnFunc)
        {
            // emit returnValue and concat orginal source to continue stream
            var newSource = Observable.Return<T>(returnFunc()).Concat(source);
            return source.Timeout(
                timeout,
                newSource
            );
        }
    }
}
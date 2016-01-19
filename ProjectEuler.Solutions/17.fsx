#r "..\packages\Humanizer.1.37.7\lib\portable-win+net40+sl50+wp8+wpa81+MonoAndroid10+MonoTouch10+Xamarin.iOS10\Humanizer.dll"

open Humanizer

let letterCount (s : string) =
    s.Replace(" ", "").Replace("-", "").Length

let answer =
    [1..1000]
    |> Seq.map (fun a -> a.ToWords())
    |> Seq.fold (fun acc elem -> acc + (letterCount elem)) 0
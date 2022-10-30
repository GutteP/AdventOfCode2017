// Kollat på CameronAavik lösning för att lära mig. 
// https://github.com/CameronAavik/AdventOfCode/blob/master/fsharp/2017/Solutions/Day01.fs

module CaptchaSolver
open Conversion

let solve window captcha = // "1122", 2
    Seq.append captcha captcha // [1,1,2,2,1,1,2,2]
    |> Seq.windowed window // [[1,1], [1,2], [2,2], [2,1], [1,1], [1,2], [2,2]]
    |> Seq.take (Seq.length captcha) // [[1,1], [1,2], [2,2], [2,1]]
    |> Seq.filter (fun w -> Seq.head w = Seq.last w) // [[1,1], [2,2]] where(x => x.first() == x.last())
    |> Seq.sumBy (Seq.head >> charToDigit) // summera alla head

let part1 (captcha : string) = 
    solve 2 captcha

let part2 (captcha : string) =
    solve  ((Seq.length captcha /2) + 1) captcha
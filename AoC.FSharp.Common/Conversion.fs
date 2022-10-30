module Conversion
open System
let charToDigit c = Char.GetNumericValue c |> int

let splitBy (c : string) f (str : string) = str.Split(c) |> f
let asIntArray : string [] -> int [] = Array.map int
let linesToSeq f (text : string) = text.Split("\n") |> Seq.map f


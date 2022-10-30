module ChecksumCalculator
open Conversion
open System.Linq

let inputTransforming (spreadsheet : string) = 
    linesToSeq (splitBy "\t" asIntArray) spreadsheet

let getLargestDiff values = (Seq.max values) - (Seq.min values)

let isValidDivisor ints i = (Seq.map ((*) i) ints).Intersect(ints).Any()
let getDivisor ints = [2 .. (Seq.max ints)] |> Seq.find (isValidDivisor ints)

let isEvenDividable a ints = (Seq.tryFind(fun x -> x % a = 0) ints).IsSome
let getDevidedProduct (ints : seq<int> ) = 
    let a = (Seq.filter(fun x -> isEvenDividable x (ints.Except([x]))) ints).First()
    let b = (Seq.filter(fun x -> x % a = 0) (ints.Except([a]))).First()
    b/a

let part1 (spreadsheet : string) =
    inputTransforming spreadsheet
    |> Seq.sumBy getLargestDiff 

// Använder multiplikation... Inspirerad av CameronAavik's lösning
let part2 (spreadsheet : string) =
    inputTransforming spreadsheet
    |> Seq.sumBy getDivisor

// Använder division
let part2Alt (spreadsheet : string) =
    inputTransforming spreadsheet
    |> Seq.sumBy getDevidedProduct
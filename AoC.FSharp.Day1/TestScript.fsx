open System.Linq

let values = [4168; 3925; 858; 2203; 440; 185;2886; 160; 1811; 4272; 4333; 2180; 174; 157; 361; 1555]
//values


////let isValidDivisor ints i = (Seq.map ((*) i) ints).Intersect(ints).Any()
////let getDivisor ints = [2 .. (Seq.max ints)] |> Seq.find (isValidDivisor ints)
////getDivisor values

//let isValidDivisor ints i = (Seq.map ((*) i) ints).Intersect(ints)
//isValidDivisor values 2

//let values = [3;4;5;8]
//let evenDividable a ints = (Seq.tryFind(fun x -> x % a = 0) ints).IsSome
//let getDevided (ints : int list ) = Seq.find(fun x -> evenDividable x (ints.Except([x]))) ints
//getDevided values

//let values = [3;4;5;8]
let isEvenDividable a ints = (Seq.tryFind(fun x -> x % a = 0) ints).IsSome
let getDevidedProduct (ints : int list ) = 
    let a = (Seq.filter(fun x -> isEvenDividable x (ints.Except([x]))) ints).First()
    let b = (Seq.filter(fun x -> x % a = 0) (ints.Except([a]))).First()
    b/a
let r = getDevidedProduct values

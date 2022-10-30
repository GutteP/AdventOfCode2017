module Reader
open System.IO

let readFile fileName = File.ReadAllText fileName


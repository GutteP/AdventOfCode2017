//open System.Linq

////let values = [1 .. 361527]
////let lap = 2
////let sq = 4
////values[(((8*lap)-sq))..((((8*lap)-sq))+((sq+(8 * lap))-1))]


////0..3    4
////4..15   12    ?..  (8*lap)
////16..35  20
////36..63  28


////0
////4

////4
////(4)+4+8

////(4)+4+8
////(4)+4+8+4+8+8

////let rec nrOfLaps (lap:int) (values:int list)  =
////    if Seq.length values = 0 then lap
////    else nrOfLaps (lap+1) values[4+(lap*8)..] 

//let rec lapN (lap:int) (values:int list)  =
//    if Seq.length values < 5+(lap*8) then {| LastLap=values; Laps=lap+1; SideLength=1+(2*lap) |}
//    else lapN (lap+1) values[4+(lap*8)..]


//let part (values: int List) sideLength x =
//    let w = values[0..sideLength-1]
//    let s = values[sideLength..(sideLength * 2)-1]
//    let e = values[sideLength * 2..(sideLength * 3)-1]
//    let n = values[sideLength * 3..(sideLength * 4)-1]
//    if w.Contains x then {| Side="w"; Index=(w |> Seq.findIndex (fun n -> n = x) ) |}
//    else if s.Contains x then {| Side="s"; Index=(s |> Seq.findIndex (fun n -> n = x) ) |}
//    else if e.Contains x then {| Side="e"; Index=(e |> Seq.findIndex (fun n -> n = x) ) |}
//    else if n.Contains x then {| Side="n"; Index=(n |> Seq.findIndex (fun n -> n = x) ) |}
//    else {| Side="none"; Index=int -1 |}

//let manhattanDistanceX (laps:int) side =
//    if side="w" || side="s" then laps-1
//    else laps
//let manhattanDistanceY (laps:int) sideLength side index =
//    if side="n" then index - (int (sideLength/2))
//    else if side="s" then index - (int ((sideLength/2)-1))
//    else if side="w" then index - (int ((sideLength/2)))
//    else if side="e" then index - (int ((sideLength/2)))
//    else 99

//let manhattanDistance (laps:int) sideLength side index =
//    let x = manhattanDistanceX laps side
//    let y = manhattanDistanceY laps sideLength side index
//    abs x + abs y


//let values = [1 .. 64]
//let info = lapN 0 values

//let infoB = part info.LastLap info.SideLength 43

//let md = manhattanDistance info.Laps info.SideLength infoB.Side infoB.Index


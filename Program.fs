open System
open System.IO
open System.Runtime.InteropServices
open Un4seen.Bass

let mathsTunes =  async {
    let n = 0
    let zero = IntPtr(n)
    let fs:FileStream = File.OpenRead("resource.bin")
    let length64 = fs.Length
    let length32 = int32(length64)
    let buffer:byte [] = Array.zeroCreate length32
    fs.Read(buffer,0,length32) |> ignore
    fs.Close |> ignore
    let pinnedArray:GCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned)
    let bufferptr:IntPtr = pinnedArray.AddrOfPinnedObject()
    let howtomakeint64with0:int = 0
    let int64with0:int64 = int64(howtomakeint64with0)
    // I don't care about this email address. However, if you wish to modify and publish the source/binary, I would suggest registering your own Bass.Net license. 
    BassNet.Registration("dm4.bade@gmail.com", "2X9222318152222")
    Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DSOUND, zero) |> ignore
    let stream = Bass.BASS_StreamCreateFile(bufferptr, int64with0, length64, BASSFlag.BASS_SAMPLE_LOOP)
    Bass.BASS_ChannelPlay(stream, true) |> ignore
}

[<EntryPoint>]
let main argv =
    printfn "f# test"
    mathsTunes |> Async.Start
    printfn "type 1st number"
    let a:string = Console.ReadLine()
    let mutable z = 0;
    if Int32.TryParse(a, &z) then
        printfn "type 2nd number"
    else printfn "invalid input"
    let b:string = Console.ReadLine()
    let mutable y = 0;
    if Int32.TryParse(b, &y) then
        Console.Beep()
    else printfn "invalid input"
    printfn "enter operation, * multiply, + add, - subtract, / divide"
    let operation = Console.ReadLine()
    printfn "calculator go brrrrrrr"
    let x:float = float z
    let w:float = float y
    let answer =
        match operation with
        | "*" -> printfn "the answer is %d" (z*y)
        | "+" -> printfn "the answer is %d" (z+y)
        | "-" -> printfn "the answer is %d" (z-y)
        | "/" -> printfn "the answer is %f" (x/w)
        | _ -> printfn "invalid option bruh"
    printfn "press any key to exit"
    System.Console.ReadKey() |> ignore // wait for user input
    0 // Return an integer exit code
let message (text: string) =
    let formattedText = text.Split(':')[1]
    formattedText.Trim()

message "[ERROR]: Invalid operation"

message "[WARNING]:  Disk almost full\r\n"

let logLevel (text: string) =
    let arr = text.Split ':'
    let formattedText = arr[0].Replace("[", "").Replace("]", "")
    formattedText.ToLower()


logLevel "[ERROR]: Invalid operation"

let reformat (text: string) =
    let newText = $"{message text} ({logLevel text})"
    newText
    
reformat "[INFO]: Operation completed"    
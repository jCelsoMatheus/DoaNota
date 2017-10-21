function terminou(result) {
    if (result.success) {
        alert("A entidade já recbeu R$ " + result.value);
    } else {
        alert(result.value);
    }
}

//Uma prática muito comum: verifica se o objeto desejado existe,
//caso contrário, "cria" o objeto atribuindo a ele outro(s) que
//pode(m) existir naquele browser em especial...
if (!navigator.getUserMedia) {
    navigator.getUserMedia = (navigator.webkitGetUserMedia ||
        navigator.mozGetUserMedia ||
        navigator.msGetUserMedia);
}

if (!window.URL) {
    window.URL = window.webkitURL;
}

var turningOn, preview, previewSrc, previewOk, cameraStream, photo, photoContext;

function tirarFoto() {
    photoContext.drawImage(preview, 0, 0, photo.width, photo.height);
    try {
        var resultado = qrcode.decode();
        var res = resultado.split('|');
        alert(res[0] + " - " + res[2]);
        var res1 = res[0].toString().replace("CFe", "");
        grava(res1, res[2]);
    } catch (ex) {
        //ignorar erros
    }
    setTimeout(tirarFoto, 100);
}


function adjustPreview() {
    //Utiliza a variável previewOk para garantir que esse código seja executado apenas uma vez!
    if (!previewOk) {
        //Regra de 3: redimensiona o elemento do vídeo e o canvas, para que fiquem
        //com uma largura de 600px e com uma altura proporcional ao vídeo da câmera
        //
        //O | 0 no final é para truncar o resultado rapidamente....
        //Venha falar comigo que eu explico pessoalmente ;)
        var height = (((preview.videoHeight * 600) / preview.videoWidth) | 0);
        if (height && !isNaN(height) && isFinite(height)) {
            preview.height = height;
            photo.height = height;
            preview.style.visibility = "";
            previewOk = true;

            tirarFoto();


            return true;
        }
        return false;
    }
    return true;
}

function waitToAdjust() {
    if (!adjustPreview()) {
        //Pois é... não rolou... Mostra de qualquer jeito... :(
        preview.style.visibility = "";
    }
    return true;
}

function getUserMedia_Success(mediaStream) {
    turningOn = false;
    //Especifica o tratador do evento "canplay", que é executado quando o
    //vídeo foi carregado, e já está pronto para reproduzir
    preview.addEventListener("canplay", adjustPreview);
    //Às vezes, canplay não é chamado, dependendo do browser... :(
    preview.addEventListener("loadeddata", adjustPreview);
    preview.addEventListener("resize", adjustPreview);
    //Às vezes, o browser não chama NENHUM, aí nós esperamos um tempinho
    setTimeout(waitToAdjust, 2500);
    if ("mozSrcObject" in preview) {
        //O Firefox trabalha de jeito diferente... por enquanto...
        previewSrc = null;
        preview.mozSrcObject = mediaStream;
    } else {
        //Para os outros browsers, basta criar uma URL para encapsular o stream, e pronto!
        previewSrc = URL.createObjectURL(mediaStream);
        preview.src = previewSrc;
    }
    //Reproduz o vídeo, efetivamente exibindo o conteúdo da câmera na página
    preview.play();
    //Aramzena o stream para uso futuro
    cameraStream = mediaStream;
    return true;
}

function getUserMedia_Error(error) {
    turningOn = false;
    alert("Erro ao obter acesso à câmera: " + error);
    return true;
}

if (!navigator.getUserMedia) {
    alert("Aparentemente seu browser não possui a API necessária para acessar a câmera! :(");
} else {
    //Obtém o vídeo da página (onde será exibido o preview)
    preview = document.getElementById("preview");
    //Ver explicação na função preview_CanPlay
    previewOk = false;
    //Obtém o canvas da página (onde será exibida a foto tirada)
    photo = document.getElementById("qr-canvas");
    //Obtém o contexto de desenho do canvas (utilizado para desenhar)
    photoContext = photo.getContext("2d");
    //Tenta obter acesso à câmera
    navigator.getUserMedia({ video: true, audio: false }, getUserMedia_Success, getUserMedia_Error);
}
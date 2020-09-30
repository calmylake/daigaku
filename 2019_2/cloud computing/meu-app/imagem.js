var VisualRecognitionV3 = require('ibm-watson/visual-recognition/v3');

var fs = require('fs');

var visualRecognition = new VisualRecognitionV3({
url: 'https://gateway.watsonplatform.net/visual-recognition/api',
version: '2018-03-19',
iam_apikey: '9Us8pIcO9DK9q0_wIy7Je5u8xIydiMrSBgzvwxmDwb-D',
});

var params = {
images_file: fs.createReadStream('imagem.jpg') // imagem localizada no diretório como o nome imagem.png
};
visualRecognition.classify(params)
.then(result => {
console.log(JSON.stringify(result, null, 2));
})
.catch(err => {
console.log(err);
});
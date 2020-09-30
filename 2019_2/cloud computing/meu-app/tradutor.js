const LanguageTranslatorV3 = require('ibm-watson/language-translator/v3');

const languageTranslator = new LanguageTranslatorV3({
iam_apikey: 'bKwOZqyo1Q1zd9MRnPGlo3lT20cQxtKV6DfpQpfrL0SN',
url: 'https://gateway.watsonplatform.net/language-translator/api/',
version: '2018-08-07',
});

languageTranslator.translate({
text: 'O gato é feio',
source: 'pt',
target: 'en' // do inglês para o português
})
.then(translation => {
console.log(translation.translations[0].translation);
})
.catch(err => {
console.log('error:', err);
});
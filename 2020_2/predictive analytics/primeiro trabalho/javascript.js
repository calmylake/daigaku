const csv = require('csv-parser')
const fs = require('fs')
const results = [];
 
fs.createReadStream('the best UseAmarelo.csv')
  .pipe(csv({}))
  .on('data', (data) => results.push(data))
  .on('end', () => {
    console.log(results);
    // [
    //   { NAME: 'Daffy Duck', AGE: '24' },
    //   { NAME: 'Bugs Bunny', AGE: '22' }
    // ]
  });

/*let array = require('./useamarelo borabora.js');

console.log(array.length);

let i = 0;
let j = 0;
let found = false;
let attfound = "";
let att = ["Date","Headline","URL","Opening Text","Hit Sentence","Source","Influencer","Country","Subregion","Language","Reach","Desktop Reach","Mobile Reach","Twitter Social Echo","Facebook Social Echo","Reddit Social Echo","National Viewership","Engagement","AVE","Sentiment","Key Phrases","Input Name","Keywords","Twitter Authority","Tweet Id","Twitter Id","Twitter Client","Twitter Screen Name","Twitter User Profile Url","Twitter Bio","Twitter Followers","Twitter Following","Alternate Date Format","Time","State","City","Document Tags"];

// preciso saber quais atributos são usáveis

while(i < att.length){
    i++;
}

i = 0
while(i < tools.length){
    j = 0;
    while(j < att.length){
        if (tools[i][att[j]].length >= 1){
            found = true;
            break;
        }
        j++;
    }
    if(found){

    }
    i++;
}
console.log(found);


*/
/*
Date
Headline
URL
Opening Text
Hit Sentence
Source
Influencer
Country
Subregion
Language
Reach
Desktop Reach
Mobile Reach
Twitter Social Echo
Facebook Social Echo
Reddit Social Echo
National Viewership
Engagement
AVE
Sentiment
Key Phrases
Input Name
Keywords
Twitter Authority
Tweet Id
Twitter Id
Twitter Client
Twitter Screen Name
Twitter User Profile Url
Twitter Bio
Twitter Followers
Twitter Following
Alternate Date Format
Time
State
City
Document Tags*/
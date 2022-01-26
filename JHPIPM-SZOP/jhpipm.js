var http = require("http");
const https = require('https');
var express = require('express');
var app = express();
var mysql = require('mysql2');
var bodyParser = require('body-parser');
const {connect} = require("http2");
const swaggerJSDoc = require('swagger-jsdoc');
const swaggerUI = require('swagger-ui-express');
const { version } = require("os");
const AdminPw = "abc123";

const options = {
    hostname: '127.0.0.1',
    port: 443,
    path: '/index.php',
    method: 'GET',
    rejectUnauthorized: false,
    requestCert: true,
    agent: false
}

const swaggerOptions ={
    definition:{
        openapi:'3.0.0',
        info:{
            title: 'Allatkert API',
            version:'1.0.0',
            description: 'Állatkert API',
            contact:{
                name: 'Galvács István JHPIPM',
                email: 'galvacs11@gmail.com',
            },
            servers:['http://localhost:3000']
        }
    },
    apis:["jhpipm.js"]
}
const swaggerDocs = swaggerJSDoc(swaggerOptions);
app.use('/api-docs', swaggerUI.serve, swaggerUI.setup(swaggerDocs));



app.use(function(reg, res, next){
    res.header("Content-Type", 'application/json');
    next();
});

var connection = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    port: '3306',
    password: '',
    database: 'allatkert'
});
connection.connect(function(err){
    if(err) throw err;
    console.log('A csatlakozás sikerült...')
});

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({
    extended: true
}));
var server = app.listen(3000, "127.0.0.1", function(){
    var host = server.address().address;
    var port = server.address().port;
    console.log("A következő portot figyeljük: https://%s:%s", host, port)
});

/**
 * @swagger
 * definitions:
 *  Allatkert:
 *   type: object
 *   properties:
 *    id:
 *     type: integer
 *     description: id
 *     example: '1'
 *    megnevezes:
 *     type: string
 *     description: Állat neve
 *     example: 'Zsiráf' 
 *    nem:
 *     type: string
 *     description: Az állat neme
 *     example: 'hím'
 *    eletkor:
 *     type: integer
 *     description: Az állat életkora hónapokban
 *     example: '12'
 *    szektor:
 *     type: integer
 *     description: A szektor ahol az állat él az állatkerten belül
 *     example: '5'
 */


/**
 * @swagger
 * /allatkert:
 *  get:
 *   summary: get all allatkert
 *   description: get all allatkert
 *   responses:
 *    200:
 *     description: succes
 *    500:
 *     description: error
 */
app.get('/allatkert', function(req, res){
    connection.query('SELECT * FROM allatkert', function(error, results, fields){
        if(error) throw error;
        res.json(results);
    });
});
/**
 * @swagger
 * /allatkert/{id}:
 *  get:
 *   summary: get allatkert by id
 *   description: Get allatkert by id
 *   parameters:
 *    - in: path
 *      name: id
 *      schema:
 *       type: integer
 *      required: true
 *      description: id
 *      example: 1
 *   responses:
 *    200:
 *     description: success
 */
 app.get('/allatkert/:id', function(req, res){
    console.log(req);
    connection.query('SELECT * FROM allatkert WHERE id=?', [req.params.id],function(error, results, fields){
        if (error) throw error;
        res.json(results);
    });
});
/**
 * @swagger
 * /addallatkert/{pw}:
 *  post:
 *   summary: add allatkert
 *   description: create allatkert to the database
 *   parameters:
 *    - in: path
 *      name: pw
 *      schema:
 *       type: string
 *      required: true
 *      description: Admin password for CRUD.
 *      example: 123
 *   requestBody:
 *    content:
 *     application/json:
 *      schema:
 *       $ref: '#/definitions/Allatkert'
 *   responses:
 *    200:
 *     description: game created succesfully
 *    500:
 *     description: failure in creating game
 */
app.post('/addallatkert/:pw', function(req, res){
    if(req.params.pw == AdminPw){
        var postData = req.body;
        connection.query('INSERT INTO allatkert SET ?', postData, function(error, results, fields){
            if(error) throw error;
            res.json(results);
        });
    }
    else{
        return res.status(403).json({'"403"':'"Unauthorized"'});
    };
});
/**
 * @swagger
 * /updateallatkert/{id}/{pw}:
 *  put:
 *   summary: update allatkert
 *   description: update allatkert
 *   consumes:
 *    - application/json
 *   produces:
 *    - application/json
 *   parameters:
 *    - in: path
 *      name: id
 *      schema:
 *       type: integer
 *      required: true
 *      description: id
 *      example: 2
 *    - in: path
 *      name: pw
 *      schema:
 *       type: string
 *      required: true
 *      description: Admin password for CRUD.
 *      example: 123
 *    - in: body
 *      name: body
 *      required: true
 *      description: body object
 *      schema:
 *       $ref: '#/definitions/Allatkert'
 *   requestBody:
 *    content:
 *     application/json:
 *      schema:
 *       $ref: '#/definitions/Allatkert'
 *   responses:
 *    200:
 *     description: success
 *     content:
 *      application/json:
 *       schema:
 *        $ref: '#/definitions/Allatkert'
 */
 
app.put('/updateallatkert/:id/:pw', function(req, res){
    if(req.params.pw == AdminPw){
        connection.query('UPDATE allatkert SET megnevezes = "'+req.body.megnevezes+'", nem = "'+req.body.nem+'", eletkor(honapokban) = "'+req.body.eletkor+'", szektor = "'+req.body.szektor+'" WHERE id = '+req.params.id, function(error, results, fields) {
            if (error) throw error;
            res.json(results);
          });
    }
    else{
        return res.status(403).json({'"403"':'"Unauthorized"'});
    };
});
/**
 * @swagger
 * /deleteallatkert/{id}/{pw}:
 *  delete:
 *   summary: delete allatkert
 *   description: delete allatkert
 *   parameters:
 *    - in: path
 *      name: id
 *      schema:
 *       type: integer
 *      required: true
 *      description: id
 *      example: 3
 *    - in: path
 *      name: pw
 *      schema:
 *       type: string
 *      required: true
 *      description: Admin password for CRUD.
 *      example: 123
 *   responses:
 *    200:
 *     description: success
 */

app.delete('/deleteallatkert/:id/:pw', function(req, res) {
    if (req.params.pw == AdminPw) {
      connection.query('DELETE FROM allatkert WHERE id ='+req.params.id, function(error, results, fields) {
        if (error) throw error;
        res.json(results);
      });
    }
    else {
      return res.status(403).json({'"403"':'"Unauthorized"'});
    };
  });
  
  app.get('/allatkertPHP', function(req, res1) {
    let data = [];
    let allatkert;
    const req1 = https.request(options, res => {
      console.log('Incoming GET request...');
      console.log(`statusCode: ${res.statusCode}`)
    
      res.on('data', chunk => {
        data.push(chunk);
      });
  
      res.on('end', () => {
        console.log('Response ended: ');
        jatekok = JSON.parse(Buffer.concat(data).toString());
        res1.send(jatekok);
      });
    })
    
    req1.on('error', error => {
      console.error(error)
    })
    req1.end();
  });
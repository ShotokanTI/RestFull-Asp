# RestFull-Asp


<h1>Como usar?</h1>

METHOD GET

<p>Para retornar todos os produtos dominio + api/produtos</p>
<p>Para retornar produtos especificos dominio + api/produtos/{id}</p>

METHOD POST

<p>Para adicionar um produto é preciso preencher o body da requisição</p>

(dominio+api/produtos, {method: 'POST', body: '{
        "Id": "5f7315394d13228bfefe342f"
        "Nome" : "Nome exemplo",
        "Descricao" : "Descricao exemplo",
        "Imagem" : "UrlExemplo",
        "Categoria" : "Categoria exemplo",
        "Preco" : "Preco exemplo",
        "Marca" : "Marca exemplo",
        "Codigo" : "Codigo exemplo"
}'});


METHOD PUT 

<p>Para dar update em alguma coleção use </p>

(dominio+api/produtos/{id}, {method: 'PUT', body: '{
        "Id": "5f7315394d13228bfefe342f"
        "Nome" : "Nome exemplo",
        "Descricao" : "Descricao exemplo",
        "Imagem" : "UrlExemplo",
        "Categoria" : "Categoria exemplo",
        "Preco" : "Preco exemplo",
        "Marca" : "Marca exemplo",
        "Codigo" : "Codigo exemplo"
}'});


METHOD DELETE

<p>Para DELETAR produtos especificos dominio + api/produtos/{id}</p>



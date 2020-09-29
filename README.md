# RestFull-Asp


<h1>Como usar?</h1>

<h1>METHOD GET</h1>

<p>Para retornar todos os produtos dominio + api/produtos</p>
<p>Para retornar produtos especificos dominio + api/produtos/{id}</p>

<h1>METHOD POST</h1>

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


<h1>METHOD PUT</h1>

<p>Para dar update em alguma coleção de Produtos use </p>

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


<h1>METHOD DELETE</h1>

<p>Para DELETAR produtos especificos use dominio + api/produtos/{id}</p>



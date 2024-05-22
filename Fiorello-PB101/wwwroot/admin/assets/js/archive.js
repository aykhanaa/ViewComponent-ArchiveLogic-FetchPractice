
let categoryArchiveBtns = document.querySelectorAll(".add-archive");

categoryArchiveBtns.forEach(item => 
    item.addEventListener("click", function ()){
    let id = parseInt(this.getAttribute("data-id"));
    fetch('category/settoarchive?id=${id}', {
        method: 'POST',
        headers: {
            "Content-type": "application/x-www-form-urlencoded; charset=UTF-8"
    },
        credentials: 'include',
        body: id
  }) 
  .then(res.json())
        .then(res => {
            
            console.log('Response: ', res);
        })
    })
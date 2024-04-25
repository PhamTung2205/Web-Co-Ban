function hien(){
    var dlvao= document.querySelector("#dlvao").value;
    var mang =dlvao.split(", ");
    for(var i=0; i<mang.length;i++){
        const newoption = document.createElement("option");
        newoption.innerText=mang[i];
        document.querySelector("#dldanhsach").appendChild(newoption);
        
    }
    
    if(dlvao.trim()===''){
        alert("Không có dữ liệu")
        document.querySelector("#dlvao").focus();
    }

}
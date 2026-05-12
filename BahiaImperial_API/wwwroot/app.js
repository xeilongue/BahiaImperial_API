const apiUrl = '/api/User';

async function LoadUsers() {
    try {
        const response = await fetch(apiUrl);
        const User = await response.json();

        const tbody = document.getElementById('tablebody');
        tbody.innerHTML = '';

        User.forEach(user => {
            tbody.innerHTML +=
            `
                <tr>
                    <td>${user.cpf_Cnpj}</td>
                    <td>${user.password}</td>
                </tr>
            `
            console.log(user);
        });
    } catch (error) {
        alert("Erro ao buscar os dados.");
        console.error(error);
    }
}

async function RegisterUser() {
    const token = document.getElementById('inputToken').value;

    if (!token) {
        alert("Acesso Negado: Cole o Token JWT primeiro!");
        return;
    }

    const newUser = {
        cpf_Cnpj: "1234567901",
        password: "123"
    };

    try {
        const resposta = await fetch(apiUrl, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${token}`
            },
            body: JSON.stringify(newUser)
        });

        if (resposta.ok) {
            alert("Usuário cadastrado com sucesso!");
            LoadUsers();
        } else {
            alert("Erro 401: Token inválido ou expirado.");
        }
    } catch (erro) {
        console.error(erro);
    }
}
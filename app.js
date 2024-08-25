document.addEventListener('DOMContentLoaded', () => {
    const form = document.getElementById('loginForm');
    const usernameInput = document.getElementById('username');
    const passwordInput = document.getElementById('password');

    if (form && usernameInput && passwordInput) {
        form.addEventListener('submit', async (event) => {
            event.preventDefault(); // Formun varsayılan gönderimini engelle

            const username = usernameInput.value;
            const password = passwordInput.value;

            const raw = JSON.stringify({ username, password });

            const requestOptions = {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: raw,
                redirect: 'follow'
            };

            try {
                const response = await fetch('http://localhost:5185/Person', requestOptions);

                if (response.ok) {
                    const result = await response.json();
                    console.log('API Response:', result); // Yanıtı konsola yazdır
                    
                    // 'status' alanını true veya false olarak kontrol edin
                    if (result.status) {
                        alert('Login successful!');
                    } else {
                        console.error('Login failed:', result); // Yanıt detaylarını yazdır
                        alert('Login failed. Please try again.');
                    }
                } else {
                    console.error('Network response was not ok:', response.statusText);
                    alert('Network response was not ok.');
                }
            } catch (error) {
                console.error('There was an error!', error);
                alert('There was an error with your request.');
            }
        });
    } else {
        console.error('Form or input elements not found');
    }
});

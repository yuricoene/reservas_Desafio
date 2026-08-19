// IMPORTANTE: Troque a porta pela porta real do seu backend
const API_URL = 'http://localhost:5180/api/reservations';

export async function fetchReservations() {
  const response = await fetch(API_URL);
  if (!response.ok) {
    throw new Error('Erro ao carregar reservas');
  }
  return response.json();
}

export async function createReservation(payload) {
  const response = await fetch(API_URL, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(payload)
  });

  const data = await response.json();

  if (!response.ok) {
    throw new Error(data.message || 'Erro ao criar reserva');
  }

  return data;
}

export async function cancelReservation(id) {
  const response = await fetch(`${API_URL}/${id}`, {
    method: 'DELETE'
  });

  if (!response.ok) {
    const data = await response.json().catch(() => ({}));
    throw new Error(data.message || 'Erro ao cancelar reserva');
  }
}

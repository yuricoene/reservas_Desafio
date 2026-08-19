import { useState } from 'react';
import { createReservation } from '../api/reservationsApi';

const ROOMS = [
  { id: 1, name: 'Sala Aurora' },
  { id: 2, name: 'Sala Horizon' },
  { id: 3, name: 'Sala Nexus' },
  { id: 4, name: 'Sala Vertex' }
];

export default function ReservationForm({ onCreated }) {
  const [form, setForm] = useState({
    roomId: '',
    title: '',
    start: '',
    end: ''
  });
  const [error, setError] = useState('');
  const [success, setSuccess] = useState('');
  const [loading, setLoading] = useState(false);

  const handleChange = (e) => {
    setForm({ ...form, [e.target.name]: e.target.value });
    setError('');
    setSuccess('');
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setError('');
    setSuccess('');

    // Validação no frontend: fim deve ser depois do início
    if (new Date(form.end) <= new Date(form.start)) {
      setError('O horário de fim deve ser depois do horário de início');
      return;
    }

    setLoading(true);

    try {
      await createReservation({
        roomId: Number(form.roomId),
        title: form.title,
        start: form.start,
        end: form.end
      });

      setSuccess('Reserva criada com sucesso!');
      setForm({ roomId: '', title: '', start: '', end: '' });
      onCreated();
    } catch (err) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="form-card">
      <h2>Nova Reserva</h2>

      {error && <div className="error-message">{error}</div>}
      {success && <div className="success-message">{success}</div>}

      <form onSubmit={handleSubmit}>
        <div className="form-group">
          <label>Sala</label>
          <select
            name="roomId"
            value={form.roomId}
            onChange={handleChange}
            required
          >
            <option value="">Selecione uma sala</option>
            {ROOMS.map((room) => (
              <option key={room.id} value={room.id}>
                {room.name}
              </option>
            ))}
          </select>
        </div>

        <div className="form-group">
          <label>Título</label>
          <input
            type="text"
            name="title"
            value={form.title}
            onChange={handleChange}
            placeholder="Ex: Reunião de planejamento"
            required
          />
        </div>

        <div className="form-row">
          <div className="form-group">
            <label>Início</label>
            <input
              type="datetime-local"
              name="start"
              value={form.start}
              onChange={handleChange}
              required
            />
          </div>
          <div className="form-group">
            <label>Fim</label>
            <input
              type="datetime-local"
              name="end"
              value={form.end}
              onChange={handleChange}
              required
            />
          </div>
        </div>

        <button className="btn btn-primary" type="submit" disabled={loading}>
          {loading ? 'Salvando...' : 'Criar Reserva'}
        </button>
      </form>
    </div>
  );
}

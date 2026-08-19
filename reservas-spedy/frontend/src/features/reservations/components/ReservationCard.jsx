export default function ReservationCard({ reservation, onCancel }) {
  const formatTime = (dateStr) => {
    return new Date(dateStr).toLocaleTimeString('pt-BR', {
      hour: '2-digit',
      minute: '2-digit'
    });
  };

  const handleCancel = () => {
    if (window.confirm(`Deseja cancelar a reserva "${reservation.title}"?`)) {
      onCancel(reservation.id);
    }
  };

  return (
    <div className="reservation-card">
      <div className="reservation-info">
        <h3>{reservation.title}</h3>
        <p>
          {formatTime(reservation.start)} — {formatTime(reservation.end)}
        </p>
        <span className="room-badge">{reservation.roomName}</span>
      </div>
      <button className="btn btn-danger" onClick={handleCancel}>
        Cancelar
      </button>
    </div>
  );
}

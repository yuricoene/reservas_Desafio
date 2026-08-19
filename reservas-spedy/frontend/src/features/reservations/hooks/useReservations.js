import { useState, useEffect, useCallback } from 'react';
import { fetchReservations, cancelReservation } from '../api/reservationsApi';

export function useReservations() {
  const [reservations, setReservations] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  const load = useCallback(async () => {
    try {
      setLoading(true);
      setError(null);
      const data = await fetchReservations();
      setReservations(data);
    } catch (err) {
      console.error(err);
      setError(err.message);
    } finally {
      setLoading(false);
    }
  }, []);

  useEffect(() => {
    load();
  }, [load]);

  const handleCancel = async (id) => {
    try {
      await cancelReservation(id);
      await load();
    } catch (err) {
      alert(err.message || 'Erro ao cancelar reserva');
    }
  };

  return {
    reservations,
    loading,
    error,
    reload: load,
    cancel: handleCancel
  };
}

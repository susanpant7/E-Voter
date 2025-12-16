export interface ApiResponse<T> {
    success: boolean;
    title: string | null;
    status: number;
    errors?: [];
    data: T;
    meta: any | null;
    timestamp: string;
}